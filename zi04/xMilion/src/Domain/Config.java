package Domain;

//rejestr do tworzenia implementacji DOM
import org.w3c.dom.bootstrap.DOMImplementationRegistry;

//Implementacja DOM Level 3 Load & Save
import org.w3c.dom.ls.DOMImplementationLS;
import org.w3c.dom.ls.LSParser; // Do serializacji (zapisywania) dokumentow

//Konfigurator i obsluga bledow
import org.w3c.dom.DOMConfiguration;
import org.w3c.dom.DOMError;
import org.w3c.dom.DOMErrorHandler;

//Do pracy z dokumentem
import org.w3c.dom.Document;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

public class Config {
	private static Config instance;

	public static Config getInstance() {
		if (instance == null) {
			instance = new Config();
		}
		return instance;
	}

	private String driver;
	private String dns;
	private String user;
	private String password;

	private Config() {
		ConfigReaderLoader loader = new ConfigReaderLoader();
		loader.readConfig();
	}

	public String getDriver() {
		return this.driver;
	}

	public String getDns() {
		return this.dns;
	}

	public String getUser() {
		return this.user;
	}

	public String getPassword() {
		return this.password;
	}

	private class ConfigReaderLoader {
		Document document;

		void readConfig() {
			try {
				/*
				 * ustawienie systemowej wlasnosci (moze byc dokonane w innym
				 * miejscu, pliku konfiguracyjnym w systemie itp.) konkretna
				 * implementacja DOM
				 */
				System.setProperty(DOMImplementationRegistry.PROPERTY,
						"org.apache.xerces.dom.DOMXSImplementationSourceImpl");
				DOMImplementationRegistry registry = DOMImplementationRegistry.newInstance();

				// pozyskanie implementacji Load & Save DOM Level 3 z rejestru
				DOMImplementationLS impl = (DOMImplementationLS) registry.getDOMImplementation("LS");

				// stworzenie DOMBuilder
				LSParser builder = impl.createLSParser(DOMImplementationLS.MODE_SYNCHRONOUS, null);

				// pozyskanie konfiguratora - koniecznie zajrzec do dokumentacji
				// co
				// mozna poustawiac
				DOMConfiguration config = builder.getDomConfig();

				// stworzenie DOMErrorHandler i zarejestrowanie w konfiguratorze
				DOMErrorHandler errorHandler = getErrorHandler();
				config.setParameter("error-handler", errorHandler);

				// set validation feature
				config.setParameter("validate", Boolean.FALSE);

				System.out.println("Loading config.xml ...");
				// sparsowanie dokumentu i pozyskanie "document" do dalszej
				// pracy
				document = builder.parseURI("config.xml");

				// praca z dokumentem, modyfikacja zawartosci etc... np.
				NodeList nodes = document.getChildNodes();
				if (nodes.getLength() > 0) {
					Node root = nodes.item(0);
					nodes = root.getChildNodes();
					for (int i = 0; i < nodes.getLength(); i++) {
						Node pn = nodes.item(i);
						if (pn.getNodeName().equals("Database")) {
							NodeList pnodes = pn.getChildNodes();
							for (int j = 0; j < pnodes.getLength(); j++) {
								Node cn = pnodes.item(j);
								if (cn.getNodeName().equals("Driver")) {
									driver = cn.getTextContent();
								} else if (cn.getNodeName().equals("Dns")) {
									dns = cn.getTextContent();
								} else if (cn.getNodeName().equals("User")) {
									user = cn.getTextContent();
								} else if (cn.getNodeName().equals("Password")) {
									password = cn.getTextContent();
								}

							}
						}
					}
				}

			} catch (Exception ex) {
				ex.printStackTrace();
			}
		}

		// obsluga bledow za pomoca anonimowej klasy wewnetrznej implementujacej
		// DOMErrorHandler
		// por. SAX ErrorHandler
		private DOMErrorHandler getErrorHandler() {
			return new DOMErrorHandler() {
				public boolean handleError(DOMError error) {
					short severity = error.getSeverity();
					if (severity == DOMError.SEVERITY_ERROR) {
						System.out.println("[dom3-error]: " + error.getMessage());
					}
					if (severity == DOMError.SEVERITY_WARNING) {
						System.out.println("[dom3-warning]: " + error.getMessage());
					}
					if (severity == DOMError.SEVERITY_FATAL_ERROR) {
						System.out.println("[dom3-fatal-error]: " + error.getMessage());
					}
					return true;
				}
			};
		}

	}
}
