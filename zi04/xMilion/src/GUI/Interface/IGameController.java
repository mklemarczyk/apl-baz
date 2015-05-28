package GUI.Interface;

import java.awt.event.ActionListener;

import Domain.Game;

public interface IGameController {

	IGameView getView();

	ActionListener getCancelEvent();

	void setMainController(IMainController mainController);

	void loadNewTest();

	ActionListener getAnswerEvent();

	void setGame(Game game);

}
