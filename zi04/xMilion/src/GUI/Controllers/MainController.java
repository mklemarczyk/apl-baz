package GUI.Controllers;

import org.javalite.activejdbc.Base;

import Domain.Config;
import Domain.Game;
import GUI.Interface.IEndGameController;
import GUI.Interface.IEndGameView;
import GUI.Interface.IGameView;
import GUI.Interface.IHighscoreView;
import GUI.Interface.IMainController;
import GUI.Interface.IMainView;
import GUI.Interface.IGameController;
import GUI.Interface.IHighscoreController;
import GUI.Interface.IMenuController;
import GUI.Interface.IMenuView;

public final class MainController implements IMainController {
	private IMainView _view;

	private IMenuController menu;
	private IGameController game;
	private IHighscoreController highscore;
	private IEndGameController endGame;

	public MainController(IMainView view) {
		this._view = view;
		this._view.setController(this);

		Base.open(Config.getInstance().getDriver(), Config.getInstance().getDns(), Config.getInstance().getUser(),
				Config.getInstance().getPassword());

		/*
		 * User p = new User(); p.set("login", "Marilyn"); p.set("password",
		 * "Monroe"); p.set("email", "m@ko.pl"); p.set("birthdate",
		 * "1990-02-21"); p.set("is_player", 1); p.saveIt();
		 * 
		 * Base.close();
		 */
	}

	@Override
	public IMainView getView() {
		return this._view;
	}

	@Override
	public void setMenuController(IMenuView menuView) {
		this.menu = new MenuController(menuView);
		this.menu.setMainController(this);
		menuView.setController(this.menu);
	}

	@Override
	public void setGameController(IGameView gameView) {
		this.game = new GameController(gameView);
		this.game.setMainController(this);
		gameView.setController(this.game);
	}

	@Override
	public void setHighscoreController(IHighscoreView highscoreView) {
		this.highscore = new HighscoreController(highscoreView);
		this.highscore.setMainController(this);
		highscoreView.setController(this.highscore);
	}

	@Override
	public void setEndGameController(IEndGameView endGameView) {
		this.endGame = new EndGameController(endGameView);
		this.endGame.setMainController(this);
		endGameView.setController(this.endGame);
	}

	@Override
	public IGameController getGameController() {
		return this.game;
	}

	@Override
	public void showEndGame(Game game) {
		this.endGame.getView().setResult(game.lastResult);
		this.endGame.getView().setPrice(game.getPrice());
		this._view.setState(MainState.EndGame);
	}
}
