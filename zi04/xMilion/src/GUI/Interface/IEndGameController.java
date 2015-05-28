package GUI.Interface;

import java.awt.event.ActionListener;

public interface IEndGameController {

	IEndGameView getView();

	ActionListener getBackEvent();

	void setMainController(IMainController mainController);

}
