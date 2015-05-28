package GUI.Controllers;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import GUI.Interface.IEndGameController;
import GUI.Interface.IEndGameView;
import GUI.Interface.IMainController;
import GUI.Interface.IMainController.MainState;

public final class EndGameController implements IEndGameController {
	IEndGameView _view;
	IMainController mainController;

	public EndGameController(IEndGameView view) {
		this._view = view;
	}

	@Override
	public IEndGameView getView() {
		return this._view;
	}

	@Override
	public void setMainController(IMainController mainController) {
		this.mainController = mainController;
	}

	@Override
	public ActionListener getBackEvent() {
		return new BackAction();
	}

	class BackAction implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent arg0) {
			mainController.getView().setState(MainState.Menu);
		}

	}
}
