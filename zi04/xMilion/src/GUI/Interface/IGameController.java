package GUI.Interface;

import java.awt.event.ActionListener;

import Domain.Game;

public interface IGameController {

	IGameView getView();

	ActionListener getCancelEvent();

	void setMainController(IMainController mainController);

	void loadNewTest();

	ActionListener getAnswerEvent();
	
	ActionListener getAnswer1Event();
	
	ActionListener getAnswer2Event();
	
	ActionListener getAnswer3Event();
	
	ActionListener getAnswer4Event();

	void setGame(Game game);

}
