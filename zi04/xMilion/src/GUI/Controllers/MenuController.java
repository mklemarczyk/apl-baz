package GUI.Controllers;

import GUI.Interface.IMenuController;
import GUI.Interface.IMenuView;

public class MenuController implements IMenuController{
	IMenuView _view;
	
	public MenuController(IMenuView view){
		this._view = view;
	}

	@Override
	public IMenuView getView() {
		return this._view;
	}
}
