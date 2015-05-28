package GUI.Views;

import java.awt.GridLayout;

import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JPanel;

import GUI.Interface.IEndGameController;
import GUI.Interface.IEndGameView;

public final class EndGameView extends JPanel implements IEndGameView {
	private static final long serialVersionUID = -8889274473587783728L;
	
	private IEndGameController controller;

	private JButton backButton;
	private JLabel gameResultLabel;
	
	public EndGameView(){
		this.backButton = new JButton("Wróć do menu");
		this.gameResultLabel = new JLabel();
		
		this.setLayout(new GridLayout(2, 0));

		this.add(backButton);
		this.add(gameResultLabel);
	}
	
	@Override
	public void setController(IEndGameController game) {
		this.controller = game;
		
		this.backButton.addActionListener(this.controller.getBackEvent());
	}

	@Override
	public void setResult(boolean result) {
		if(result == true){
			this.gameResultLabel.setText("Wygrana");
		}else{
			this.gameResultLabel.setText("Porażka");
		}
	}

}
