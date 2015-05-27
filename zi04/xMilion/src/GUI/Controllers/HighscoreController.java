package GUI.Controllers;

import GUI.Interface.IHighscoreController;
import GUI.Interface.IHighscoreView;

public final class HighscoreController implements IHighscoreController {
	IHighscoreView _view;
	
	public HighscoreController(IHighscoreView view){
		this._view = view;
	}

	@Override
	public IHighscoreView getView() {
		return this._view;
	}
}
