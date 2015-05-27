
public class Program {

	public static void main(String[] args) {
		GUI.Interface.IMainController controller = new GUI.Controllers.MainController(new GUI.Views.MainView());
		controller.getView().show();
	}
}
