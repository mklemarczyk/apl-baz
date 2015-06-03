package GUI.Views;

import java.awt.GridLayout;

import javax.swing.JButton;
import javax.swing.JPanel;

import GUI.Interface.IMenuController;
import GUI.Interface.IMenuView;

public final class MenuView extends JPanel implements IMenuView {
	private static final long serialVersionUID = -898376453303536619L;

	private IMenuController controller;

	private JButton newGameButton;
	private JButton resumeGameButton;
	private JButton highscoreButton;
	//private JButton settingsButton;
	private JButton closeButton;

	public MenuView() {
		this.setLayout(new GridLayout(4, 0));

		this.newGameButton = new JButton("Nowa gra");
		this.resumeGameButton = new JButton("Wznów grę");
		this.highscoreButton = new JButton("Wyniki");
		//this.settingsButton = new JButton("Ustawienia");
		this.closeButton = new JButton("Close");

		this.add(this.newGameButton);
		this.add(this.resumeGameButton);
		this.add(this.highscoreButton);
		//this.add(this.settingsButton);
		this.add(this.closeButton);
	}

	@Override
	public void setController(IMenuController menu) {
		this.controller = menu;

		this.newGameButton.addActionListener(this.controller.getNewGameEvent());
		this.resumeGameButton.addActionListener(this.controller.getResumeGameEvent());
		this.highscoreButton.addActionListener(this.controller.getHighscoreEvent());
		//this.settingsButton.addActionListener(this.controller.getSettingsEvent());
		this.closeButton.addActionListener(this.controller.getCloseEvent());
	}

}
