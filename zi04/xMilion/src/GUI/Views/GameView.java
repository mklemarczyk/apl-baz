package GUI.Views;

import java.awt.GridLayout;

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
		
		this.setLayout(new GridLayout(4, 0));
		
		JPanel options = new JPanel();
		options.setLayout(new GridLayout(2, 2));
		
		this.add(cancelButton);
		this.add(questionLabel);
		this.add(timeLabel);
		this.add(options);
		
		options.add(answer1);
		options.add(answer2);
		options.add(answer3);
		options.add(answer4);
	}
	
	@Override
	public void setController(IGameController game) {
		this.controller = game;
		
		this.cancelButton.addActionListener(this.controller.getCancelEvent());
		this.answer1.addActionListener(this.controller.getAnswerEvent());
		this.answer2.addActionListener(this.controller.getAnswerEvent());
		this.answer3.addActionListener(this.controller.getAnswerEvent());
		this.answer4.addActionListener(this.controller.getAnswerEvent());
	}

	@Override
	public void setQuestion(String text) {
		this.questionLabel.setText(text);
	}

	@Override
	public void setOptions(String ans1, String ans2, String ans3, String ans4) {
		this.answer1.setText(ans1);
		this.answer2.setText(ans2);
		this.answer3.setText(ans3);
		this.answer4.setText(ans4);
	}

}
