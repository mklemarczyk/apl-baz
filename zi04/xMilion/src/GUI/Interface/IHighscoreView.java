package GUI.Interface;

import java.util.List;

import Domain.Score;

public interface IHighscoreView extends GUI.Common.IWindow {

	void setController(IHighscoreController highscore);

	void loadData(List<Score> highscores);

	void unloadData();

}
