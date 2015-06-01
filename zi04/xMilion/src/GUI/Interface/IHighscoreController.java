package GUI.Interface;

import java.awt.event.ActionListener;

import javax.swing.event.AncestorListener;

public interface IHighscoreController {

	IHighscoreView getView();

	void setMainController(IMainController mainController);

	ActionListener getCloseEvent();

	AncestorListener getPanelEvent();

}
