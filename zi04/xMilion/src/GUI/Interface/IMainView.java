package GUI.Interface;

import GUI.Interface.IMainController.MainState;

public interface IMainView extends GUI.Common.IWindow {

	void setState(MainState state);

	void setController(IMainController mainController);

	void close();

}
