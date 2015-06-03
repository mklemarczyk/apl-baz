package GUI.Interface;

public interface IEndGameView extends GUI.Common.IWindow {

	void setController(IEndGameController game);

	void setResult(boolean result);

	void setPrice(int price);

}
