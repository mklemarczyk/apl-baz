package GUI.Interface;

public interface IMainController {

	IMainView getView();

	enum MainState{
		Menu, Game, Highscore, Settings, EndGameSuccess, EndGameFailed
	}

	void setMenuController(IMenuView menuView);

	void setGameController(IGameView gameView);
	
	void setHighscoreController(IHighscoreView highscoreView);
	
	void setEndGameController(IEndGameView endGameView);

	IGameController getGameController();

}
