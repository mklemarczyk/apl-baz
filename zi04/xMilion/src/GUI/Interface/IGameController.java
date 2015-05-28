package GUI.Interface;

import java.awt.event.ActionListener;

public interface IGameController {

	IGameView getView();

	ActionListener getCancelEvent();

	void setMainController(IMainController mainController);

}
