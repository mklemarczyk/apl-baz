package GUI.Interface;

import java.awt.event.ActionListener;

public interface IMenuController {

	IMenuView getView();

	ActionListener getNewGameEvent();

	ActionListener getResumeGameEvent();

	ActionListener getHighscoreEvent();

	ActionListener getSettingsEvent();

	ActionListener getCloseEvent();

	void setMainController(IMainController mainController);
	
}
