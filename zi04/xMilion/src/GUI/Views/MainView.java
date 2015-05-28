package GUI.Views;

import javax.swing.JFrame;

import GUI.Interface.IMainController;
import GUI.Interface.IMainController.MainState;
import GUI.Interface.IMainView;

public final class MainView extends JFrame implements IMainView {
	private static final long serialVersionUID = 377641263959650820L;

	private IMainController controller;

	private MenuView menuView;
	private GameView gameView;
	private HighscoreView highscoreView;

	private MainState state;

	public MainView() {
		this.menuView = new MenuView();
		this.gameView = new GameView();
		this.highscoreView = new HighscoreView();

		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}

	@Override
	public void setController(IMainController controller) {
		this.controller = controller;
		this.controller.setMenuController(this.menuView);
		this.controller.setGameController(this.gameView);
		this.controller.setHighscoreController(this.highscoreView);
	}

	@Override
	public void setState(MainState state) {
		if (this.state != null) {
			switch (this.state) {
				case Menu:
					this.remove(this.menuView);
					break;
				case Game:
					this.remove(this.gameView);
					break;
				case Highscore:
					this.remove(this.highscoreView);
					break;
			}
		}
		if (state != null) {
			switch (state) {
				case Menu:
					this.add(this.menuView);
					break;
				case Game:
					this.add(this.gameView);
					break;
				case Highscore:
					this.add(this.highscoreView);
					break;
			}
		}
		this.state = state;
		this.pack();
	}

}
