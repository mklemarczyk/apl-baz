package GUI.Views;

import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JPanel;

import GUI.Interface.IGameController;
import GUI.Interface.IGameView;

public final class GameView extends JPanel implements IGameView {
	private static final long serialVersionUID = -8889274473587783728L;
	
	private IGameController controller;

	private JButton cancelButton;
	private JLabel questionLabel;
	private JLabel timeLabel;
	private JButton answer1;
	private JButton answer2;
	private JButton answer3;
	private JButton answer4;
	
	public GameView(){
		this.cancelButton = new JButton("Zrezygnuj");
		this.questionLabel = new JLabel();
		this.timeLabel = new JLabel();
		this.answer1 = new JButton();
		this.answer2 = new JButton();
		this.answer3 = new JButton();
		this.answer4 = new JButton();
		
		this.add(cancelButton);
		this.add(questionLabel);
		this.add(timeLabel);
		this.add(answer1);
		this.add(answer2);
		this.add(answer3);
		this.add(answer4);
	}
	
	@Override
	public void setController(IGameController game) {
		this.controller = game;
		
		this.cancelButton.addActionListener(this.controller.getCancelEvent());
	}

}
