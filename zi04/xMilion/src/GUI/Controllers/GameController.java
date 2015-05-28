package GUI.Controllers;

import java.awt.event.ActionListener;

import GUI.Interface.IGameController;
import GUI.Interface.IGameView;
import GUI.Interface.IMainController;

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

	@Override
	public ActionListener getCancelEvent() {
		// TODO Auto-generated method stub
		return null;
	}
	
	@Override
	public void setMainController(IMainController mainController) {
		this.mainController = mainController;
	}
}
