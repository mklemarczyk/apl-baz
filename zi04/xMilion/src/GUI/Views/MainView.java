package GUI.Views;

import java.awt.Dimension;
import java.awt.Toolkit;

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
	private EndGameView endGameView;

	private MainState state;

	public MainView() {
		this.menuView = new MenuView();
		this.gameView = new GameView();
		this.highscoreView = new HighscoreView();
		this.endGameView = new EndGameView();

		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		this.setTitle("Milionerzy");
	}

	@Override
	public void setController(IMainController controller) {
		this.controller = controller;
		this.controller.setMenuController(this.menuView);
		this.controller.setGameController(this.gameView);
		this.controller.setHighscoreController(this.highscoreView);
		this.controller.setEndGameController(this.endGameView);
		
		 Dimension screenDim = Toolkit.getDefaultToolkit().getScreenSize();
		
		this.setMinimumSize(new Dimension(400, 400));
		this.setMaximumSize(screenDim);
		
		this.setState(MainState.Menu);
		
        // Determine the new location of the window
        int w = this.getSize().width;
        int h = this.getSize().height;
        int x = (screenDim.width-w)/2;
        int y = (screenDim.height-h)/2;

        // Move the window
        this.setLocation(x, y);
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
				case EndGame:
					this.remove(this.endGameView);
					break;
				default:
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
				case EndGame:
					this.add(this.endGameView);
					break;
				default:
					break;
			}
		}
		
		this.state = state;

		this.pack();
		this.setSize(new Dimension(400, 400));
		this.repaint();
	}

	@Override
	public void close() {
		this.setVisible(false);
	}

}
