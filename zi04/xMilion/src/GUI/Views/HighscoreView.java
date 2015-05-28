package GUI.Views;

import javax.swing.JPanel;

import GUI.Interface.IHighscoreController;
import GUI.Interface.IHighscoreView;

public final class HighscoreView extends JPanel implements IHighscoreView {
	private static final long serialVersionUID = -4218723085723083264L;
	
	private IHighscoreController controller;

	@Override
	public void setController(IHighscoreController highscore) {
		this.controller = highscore;
	}

}
