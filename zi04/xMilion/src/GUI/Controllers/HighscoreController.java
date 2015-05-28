package GUI.Controllers;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

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

	@Override
	public ActionListener getCloseEvent() {
		return new CloseAction();
	}
	
	class CloseAction implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent arg0) {
			mainController.getView().close();
		}

	}
}
