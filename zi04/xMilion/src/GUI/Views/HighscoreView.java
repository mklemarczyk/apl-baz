package GUI.Views;

import java.awt.GridLayout;
import java.util.List;

import javax.swing.JButton;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.table.AbstractTableModel;

import Domain.Score;
import GUI.Interface.IHighscoreController;
import GUI.Interface.IHighscoreView;

public final class HighscoreView extends JPanel implements IHighscoreView {
	private static final long serialVersionUID = -4218723085723083264L;

	private IHighscoreController controller;

	private JButton closeButton;
	private JTable scoreTable;

	public HighscoreView() {
		this.closeButton = new JButton("Wróć do menu");

		this.scoreTable = new JTable();

		JScrollPane scrollScorePane = new JScrollPane(scoreTable);
		this.scoreTable.setFillsViewportHeight(true);

		this.setLayout(new GridLayout(2, 1));

		this.add(closeButton);
		this.add(scrollScorePane);

	}

	@Override
	public void setController(IHighscoreController highscore) {
		this.controller = highscore;

		this.closeButton.addActionListener(this.controller.getCloseEvent());
		this.addAncestorListener(this.controller.getPanelEvent());
	}

	@Override
	public void loadData(List<Score> highscores) {
		this.scoreTable.setModel(new HighscoreTableModel(highscores));
	}

	@Override
	public void unloadData() {
		this.scoreTable.setModel(new HighscoreTableModel(null));
	}

	private class HighscoreTableModel extends AbstractTableModel {
		private static final long serialVersionUID = -5450353826839947395L;
		private String[] columnNames = { "Nickname", "Score" };
		private Score[] rowData;

		public HighscoreTableModel(List<Score> highscores) {
			if (highscores != null) {
				this.rowData = highscores.toArray(new Score[] {});
			}
		}

		@Override
		public int getColumnCount() {
			return columnNames.length;
		}

		@Override
		public String getColumnName(int col) {
			return columnNames[col];
		}

		@Override
		public int getRowCount() {
			return rowData.length;
		}

		@Override
		public Object getValueAt(int rowIndex, int columnIndex) {
			Score score = rowData[rowIndex];
			switch (columnIndex) {
				case 0:
					return score.getUser().getLogin();
				case 1:
					return score.getValue();
				default:
					return null;
			}
		}

	}

}
