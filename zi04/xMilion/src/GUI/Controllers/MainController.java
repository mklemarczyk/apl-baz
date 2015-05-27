package GUI.Controllers;

import GUI.Interface.IMainController;
import GUI.Interface.IMainView;

public final class MainController implements IMainController {
	IMainView _view;
	
	public MainController(IMainView view){
		this._view = view;
	}

	@Override
	public IMainView getView() {
		return this._view;
	}
}
