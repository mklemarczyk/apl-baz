package GUI.Interface;

import Domain.Game;

public interface IMainController {

	IMainView getView();

	enum MainState{
		Menu, Game, Highscore, Settings, EndGame
	}

	void setMenuController(IMenuView menuView);

	void setGameController(IGameView gameView);
	
	void setHighscoreController(IHighscoreView highscoreView);
	
	void setEndGameController(IEndGameView endGameView);

	IGameController getGameController();

	void showEndGame(Game game);

}
