package Domain;

import java.io.File;
import java.util.ArrayList;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;

//rejestr do tworzenia implementacji DOM
import org.w3c.dom.bootstrap.DOMImplementationRegistry;

//Implementacja DOM Level 3 Load & Save
import org.w3c.dom.ls.DOMImplementationLS;
import org.w3c.dom.ls.LSParser; // Do serializacji (zapisywania) dokumentow
import org.w3c.dom.Attr;
//Konfigurator i obsluga bledow
import org.w3c.dom.DOMConfiguration;
import org.w3c.dom.DOMError;
import org.w3c.dom.DOMErrorHandler;

//Do pracy z dokumentem
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.NamedNodeMap;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

public class Game {
	public final int testId;
	public int currentQuestionPos;
	public final ArrayList<ResultQuestion> results;

	public boolean lastResult;
	public int currentQuestionId;
	public int time;

	public Game(int testId) {
		this.testId = testId;
		this.currentQuestionId = 0;
		this.currentQuestionPos = -1;
		this.lastResult = true;
		this.time = 60;
		this.results = new ArrayList<ResultQuestion>();
	}

	public void saveState() {
		GameContent content = new GameContent();
		content.saveGameState(this, "gameState.xml");
	}

	public Game readState() {
		GameContent content = new GameContent();
		return content.readGameState("gameState.xml");
	}

	private class GameContent {
		public Game readGameState(String fileName) {
			try {
				Game game = null;
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

				System.out.println("Loading " + fileName + "...");
				// sparsowanie dokumentu i pozyskanie "document" do dalszej
				// pracy
				Document document = builder.parseURI(fileName);

				// praca z dokumentem, modyfikacja zawartosci etc... np.
				// tutaj dodanie nowego pracownika poprzez skopiowanie innego
				Element elem = document.getDocumentElement();// .getRoot();.getElementById("two.worker");

				NamedNodeMap rootAttrs = elem.getAttributes();
				for (int i = 0, c = rootAttrs.getLength(); i < c; i++) {
					Node rootAttr = rootAttrs.item(i);
					if (rootAttr.getNodeName() == "testId") {
						int testId = Integer.parseInt(rootAttr.getTextContent());
						game = new Game(testId);
					}
				}

				NodeList rootChilds = elem.getChildNodes();
				for (int i = 0, c = rootChilds.getLength(); i < c; i++) {
					Node rootAttr = rootChilds.item(i);
					if (rootAttr.getNodeName() == "QuestionResult") {
						NamedNodeMap qrAttrs = elem.getAttributes();
						ResultQuestion result = new ResultQuestion();
						result.testId = game.testId;
						for (int j = 0, d = qrAttrs.getLength(); j < d; j++) {
							Node qrAttr = qrAttrs.item(j);
							if (qrAttr.getNodeName() == "id") {
								int questionId = Integer.parseInt(qrAttr.getTextContent());
								result.questionId = questionId;
							} else if (qrAttr.getNodeName() == "position") {
								int questionPos = Integer.parseInt(qrAttr.getTextContent());
								result.questionPos = questionPos;
							} else if (qrAttr.getNodeName() == "result") {
								boolean havePoint = Boolean.parseBoolean(qrAttr.getTextContent());
								result.havePoint = havePoint;
							}
						}

						game.results.add(result);
					}
				}

				return game;
			} catch (Exception ex) {
				ex.printStackTrace();
			}
			return null;
		}

		public void saveGameState(Game game, String fileName) {
			try {
				DocumentBuilderFactory docFactory = DocumentBuilderFactory.newInstance();
				DocumentBuilder docBuilder = docFactory.newDocumentBuilder();

				// root elements
				Document doc = docBuilder.newDocument();

				// public final int testId;
				// public int currentQuestionPos;
				// public final ArrayList<ResultQuestion> results;

				Element rootElement = doc.createElement("GameState");
				doc.appendChild(rootElement);

				// set attribute to staff element
				Attr rootAttr = doc.createAttribute("testId");
				rootAttr.setValue(Integer.toString(testId));
				rootElement.setAttributeNode(rootAttr);

				for (ResultQuestion result : results) {
					Element resultNode = doc.createElement("QuestionResult");

					Attr attr;
					attr = doc.createAttribute("id");
					attr.setValue(Integer.toString(result.questionId));
					resultNode.setAttributeNode(attr);

					attr = doc.createAttribute("position");
					attr.setValue(Integer.toString(result.questionPos));
					resultNode.setAttributeNode(attr);

					attr = doc.createAttribute("result");
					attr.setValue(Boolean.toString(result.havePoint));
					resultNode.setAttributeNode(attr);

					rootElement.appendChild(resultNode);
				}

				// write the content into xml file
				TransformerFactory transformerFactory = TransformerFactory.newInstance();
				Transformer transformer = transformerFactory.newTransformer();
				DOMSource source = new DOMSource(doc);

				StreamResult result = new StreamResult(new File(fileName));
				transformer.transform(source, result);

				System.out.println("Saving " + fileName + " ...");

			} catch (Exception ex) {
				ex.printStackTrace();
			}
		}

		// obsluga bledow za pomoca anonimowej klasy wewnetrznej implementujacej
		// DOMErrorHandler
		// por. SAX ErrorHandler
		public DOMErrorHandler getErrorHandler() {
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
