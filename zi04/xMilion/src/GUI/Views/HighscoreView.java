package GUI.Views;

import javax.swing.JButton;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTable;

import GUI.Interface.IHighscoreController;
import GUI.Interface.IHighscoreView;

public final class HighscoreView extends JPanel implements IHighscoreView {
	private static final long serialVersionUID = -4218723085723083264L;
	
	private IHighscoreController controller;

	private JButton closeButton;
	private JTable scoreTable;

	public HighscoreView(){
		this.closeButton = new JButton("Wróć do menu");
		
		this.scoreTable = new JTable();
		//this.scoreTable.
		
		JScrollPane scrollScorePane = new JScrollPane(scoreTable);
		this.scoreTable.setFillsViewportHeight(true);
		
		this.add(scrollScorePane);
	}
	
	@Override
	public void setController(IHighscoreController highscore) {
		this.controller = highscore;
		
		this.closeButton.addActionListener(this.controller.getCloseEvent());
	}

}
