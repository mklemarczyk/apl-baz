package GUI.Controllers;

import GUI.Interface.IHighscoreController;
import GUI.Interface.IHighscoreView;
import GUI.Interface.IMainController;

public final class HighscoreController implements IHighscoreController {
	IHighscoreView _view;
	IMainController mainController;
	
	public HighscoreController(IHighscoreView view){
		this._view = view;
	}

	@Override
	public IHighscoreView getView() {
		return this._view;
	}
	
	@Override
	public void setMainController(IMainController mainController) {
		this.mainController = mainController;
	}
}
