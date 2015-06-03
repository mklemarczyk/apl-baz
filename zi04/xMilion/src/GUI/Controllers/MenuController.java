package GUI.Controllers;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import Domain.Game;
import GUI.Interface.IMainController;
import GUI.Interface.IMenuController;
import GUI.Interface.IMenuView;

public class MenuController implements IMenuController {
	IMenuView _view;
	IMainController mainController;

	public MenuController(IMenuView view) {
		this._view = view;
	}

	@Override
	public IMenuView getView() {
		return this._view;
	}

	@Override
	public void setMainController(IMainController mainController) {
		this.mainController = mainController;
	}

	@Override
	public ActionListener getNewGameEvent() {
		return new NewGameAction();
	}

	@Override
	public ActionListener getResumeGameEvent() {
		return new ResumeGameAction();
	}

	@Override
	public ActionListener getHighscoreEvent() {
		return new HighscoreAction();
	}

	@Override
	public ActionListener getSettingsEvent() {
		return new SettingsAction();
	}

	@Override
	public ActionListener getCloseEvent() {
		return new CloseAction();
	}

	class NewGameAction implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent arg0) {
			mainController.getView().setState(IMainController.MainState.Game);
			mainController.getGameController().loadNewTest();
		}

	}

	class ResumeGameAction implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent arg0) {
			mainController.getView().setState(IMainController.MainState.Game);
			Game game = new Game(0, 0);
			game = game.readState();
			if (game != null) {
				mainController.getGameController().setGame(game);
			} else {
				mainController.getGameController().loadNewTest();
			}
		}

	}

	class HighscoreAction implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent arg0) {
			mainController.getView().setState(IMainController.MainState.Highscore);
		}

	}

	class SettingsAction implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent arg0) {
			mainController.getView().setState(IMainController.MainState.Settings);
		}

	}

	class CloseAction implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent arg0) {
			mainController.getView().close();
		}

	}
}
