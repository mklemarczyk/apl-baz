package GUI.Controllers;

import GUI.Interface.IGameController;
import GUI.Interface.IGameView;

public final class GameController implements IGameController {
	IGameView _view;
	
	public GameController(IGameView view){
		this._view = view;
	}

	@Override
	public IGameView getView() {
		return this._view;
	}
}
