package GUI.Controllers;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.List;

import javax.swing.event.AncestorEvent;
import javax.swing.event.AncestorListener;

import org.javalite.activejdbc.Base;

import Domain.Config;
import Domain.Score;
import Domain.User;
import GUI.Interface.IHighscoreController;
import GUI.Interface.IHighscoreView;
import GUI.Interface.IMainController;
import GUI.Interface.IMainController.MainState;

public final class HighscoreController implements IHighscoreController {
	IHighscoreView _view;
	IMainController mainController;

	private void loadData() {
		Base.open(Config.getInstance().getDriver(), Config.getInstance().getDns(), Config.getInstance().getUser(),
				Config.getInstance().getPassword());
		@SuppressWarnings("unchecked")
		List<Score> highscores = Score.findAll().orderBy("value").include(User.class);
		this._view.loadData(highscores);
		Base.close();
	}

	private void unloadData() {
		this._view.unloadData();
	}

	public HighscoreController(IHighscoreView view) {
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
	public AncestorListener getPanelEvent() {
		return new PanelAction();
	}

	@Override
	public ActionListener getCloseEvent() {
		return new CloseAction();
	}

	class PanelAction implements AncestorListener {

		@Override
		public void ancestorAdded(AncestorEvent arg0) {
			loadData();
		}

		@Override
		public void ancestorMoved(AncestorEvent arg0) {

		}

		@Override
		public void ancestorRemoved(AncestorEvent arg0) {
			unloadData();
		}

	}

	class CloseAction implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent arg0) {
			mainController.getView().setState(MainState.Menu);
		}

	}
}
