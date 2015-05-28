package GUI.Controllers;

import org.javalite.activejdbc.Base;

import Domain.User;
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
	
	public MainController(IMainView view){
		this._view = view;
		this._view.setController(this);
		
		Base.open("com.mysql.jdbc.Driver", "jdbc:mysql://localhost/apl-baz-pr4", "root", "usbw");
		
		User p = new User();
		p.set("login", "Marilyn");
		p.set("password", "Monroe");
		p.saveIt();
		
		this._view.setState(MainState.Menu);
		
	}

	@Override
	public IMainView getView() {
		return this._view;
	}

	@Override
	public void setMenuController(IMenuView menuView) {
		menuView.setController(this.menu);
		
	}

	@Override
	public void setGameController(IGameView gameView) {
		gameView.setController(this.game);
	}

	@Override
	public void setHighscoreController(IHighscoreView highscoreView) {
		highscoreView.setController(this.highscore);
	}
}
