package GUI.Views;

import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.GridLayout;
import java.awt.Insets;

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
	private JLabel priceLabel;
	private JButton answer1;
	private JButton answer2;
	private JButton answer3;
	private JButton answer4;

	public GameView() {
		this.cancelButton = new JButton("Zrezygnuj");
		this.questionLabel = new JLabel();
		this.timeLabel = new JLabel();
		this.priceLabel = new JLabel("100 zł");
		this.answer1 = new JButton();
		this.answer2 = new JButton();
		this.answer3 = new JButton();
		this.answer4 = new JButton();

		// this.setLayout(new GridLayout(4, 0));

		this.setLayout(new GridBagLayout());
		GridBagConstraints c = new GridBagConstraints();

		// Price
		c.fill = GridBagConstraints.VERTICAL;
		c.weightx = 0.5;
		c.gridx = 0;
		c.gridy = 0;
		this.add(priceLabel, c);
		
		// Cancel
		c.fill = GridBagConstraints.HORIZONTAL;
		c.weightx = 0.5;
		c.gridx = 1;
		c.gridy = 0;
		this.add(cancelButton, c);

		// Time
		c.fill = GridBagConstraints.VERTICAL;
		c.weightx = 0.5;
		//c.insets = new Insets(0, 20, 0, 0); // left padding
		c.gridx = 2;
		c.gridy = 0;
		this.add(timeLabel, c);

		// Question
		c.fill = GridBagConstraints.BOTH;
		c.ipady = 20;      //make this component tall
		c.weightx = 0.0;
		c.gridwidth = 3;
		c.gridx = 0;
		c.gridy = 1;
		this.add(questionLabel, c);

		// Options
		JPanel options = new JPanel();
		options.setLayout(new GridLayout(2, 2));

		c.fill = GridBagConstraints.HORIZONTAL;
		c.ipady = 0;       //reset to default
		c.weighty = 1.0;   //request any extra vertical space
		c.anchor = GridBagConstraints.PAGE_END; //bottom of space
		c.insets = new Insets(10,0,0,0);  //top padding
		c.gridx = 0;       //aligned with button 2
		c.gridwidth = 3;   //2 columns wide
		c.gridy = 2;       //third row
		this.add(options, c);

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

	@Override
	public void setTime(int time) {
		this.timeLabel.setText(String.format("%d s", time));
	}

	@Override
	public void setPrice(int value) {
		this.priceLabel.setText(String.format("%d zł", value));
	}

}
