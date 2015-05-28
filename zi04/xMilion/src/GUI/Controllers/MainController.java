package GUI.Controllers;

import org.javalite.activejdbc.Base;

import Domain.User;
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
	
	public MainController(IMainView view){
		this._view = view;
		this._view.setController(this);
		
		Base.open("com.mysql.jdbc.Driver", "jdbc:mysql://localhost/apl-baz-pr4", "root", "usbw");
		
		User p = new User();
		p.set("login", "Marilyn");
		p.set("password", "Monroe");
		p.set("email", "m@ko.pl");
		p.set("birthdate", "1990-02-21");
		p.set("is_player", 1);
		p.saveIt();
		
		Base.close();
		
		this._view.setState(MainState.Menu);
		
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
		return game;
	}
}
