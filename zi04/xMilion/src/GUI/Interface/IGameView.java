package GUI.Interface;

public interface IGameView extends GUI.Common.IWindow {

	void setController(IGameController game);

	void setQuestion(String text);

	void setOptions(String ans1, String ans2, String ans3, String ans4);

}
