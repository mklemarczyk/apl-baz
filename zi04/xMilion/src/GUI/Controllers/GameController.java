package GUI.Controllers;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import GUI.Interface.IGameController;
import GUI.Interface.IGameView;
import GUI.Interface.IMainController;
import GUI.Interface.IMainController.MainState;

public final class GameController implements IGameController {
	IGameView _view;
	IMainController mainController;
	
	public GameController(IGameView view){
		this._view = view;
	}

	@Override
	public IGameView getView() {
		return this._view;
	}

	public ActionListener getCancelEvent() {
		return new CancelAction();
	}
	
	@Override
	public void setMainController(IMainController mainController) {
		this.mainController = mainController;
	}
	
	class CancelAction implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent arg0) {
			mainController.getView().setState(MainState.Menu);
		}

	}
}
