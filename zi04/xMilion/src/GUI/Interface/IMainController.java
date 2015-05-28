package GUI.Interface;

public interface IMainController {

	IMainView getView();

	enum MainState{
		Menu, Game, Highscore, Settings
	}

	void setMenuController(IMenuView menuView);

	void setGameController(IGameView gameView);
	
	void setHighscoreController(IHighscoreView highscoreView);
	
}
