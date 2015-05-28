package GUI.Interface;

import java.awt.event.ActionListener;

public interface IHighscoreController {

	IHighscoreView getView();

	void setMainController(IMainController mainController);

	ActionListener getCloseEvent();

}
