package GUI.Controllers;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;
import java.util.Timer;
import java.util.TimerTask;

import org.javalite.activejdbc.Base;
import org.javalite.activejdbc.LazyList;
import org.javalite.activejdbc.Model;

import Domain.Config;
import Domain.Option;
import Domain.Question;
import Domain.ResultQuestion;
import Domain.Test;
import Domain.TestItem;
import GUI.Interface.IGameController;
import GUI.Interface.IGameView;
import GUI.Interface.IMainController;
import GUI.Interface.IMainController.MainState;

public final class GameController implements IGameController {
	IGameView _view;
	IMainController mainController;

	int testId;
	int questionId;
	int questionPos;
	boolean lastResult;
	ArrayList<ResultQuestion> results;

	Timer timer;
	int time;

	public GameController(IGameView view) {
		this._view = view;
		this.timer = new Timer();
	}

	@Override
	public IGameView getView() {
		return this._view;
	}

	@Override
	public void setMainController(IMainController mainController) {
		this.mainController = mainController;
	}

	@Override
	public void loadNewTest() {
		this.lastResult = true;
		this.results = new ArrayList<ResultQuestion>();

		Base.open(Config.getInstance().getDriver(), Config.getInstance().getDns(), Config.getInstance().getUser(), Config.getInstance().getPassword());

		Test test = new Test();
		test.saveIt();
		LazyList<Model> questions = Question.findAll();
		for (Model question : questions) {
			TestItem testItem = new TestItem();
			testItem.set("test_id", test.get("id"));
			testItem.set("question_id", question.get("id"));
			testItem.saveIt();
		}
		Base.close();

		this.testId = test.getInteger("id");
		this.questionPos = -1;
		this.loadNextQuestion();

		restartTimer();
	}

	@Override
	public ActionListener getCancelEvent() {
		return new CancelAction();
	}

	@Override
	public ActionListener getAnswerEvent() {
		return new AnswerAction();
	}

	private void restartTimer() {
		this.time = 60;
		_view.setTime(time);
		if (this.timer != null) {
			this.timer.cancel();
		}
		this.timer = new Timer();
		this.timer.scheduleAtFixedRate(new TimerTask() {
			@Override
			public void run() {
				if (time > 1) {
					time--;
					_view.setTime(time);
				} else {
					lastResult = false;
					loadNextQuestion();
				}
			}
		}, 1000, 1000);
	}

	private void loadNextQuestion() {
		if (lastResult == false) {
			mainController.getView().setState(MainState.EndGameFailed);
			this.timer.cancel();
		} else {
			questionPos++;
			Base.open(Config.getInstance().getDriver(), Config.getInstance().getDns(), Config.getInstance().getUser(), Config.getInstance().getPassword());
			LazyList<Model> testItems = TestItem.find("test_id = ?", testId);
			if (questionPos < testItems.size()) {
				Model testItem = testItems.get(questionPos);
				int questionId = testItem.getInteger("question_id");
				this.questionId = questionId;

				Model question = Question.findById(questionId);
				this._view.setQuestion(question.getString("content"));

				LazyList<Option> options = Option.where("question_id = ?", questionId);
				this._view.setOptions(options.get(0).getString("content"), options.get(1).getString("content"), options
						.get(2).getString("content"), options.get(3).getString("content"));

			} else {
				mainController.getView().setState(MainState.EndGameSuccess);
			}
			Base.close();
		}
		restartTimer();
	}

	class CancelAction implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent arg0) {
			timer.cancel();
			mainController.getView().setState(MainState.Menu);
		}

	}

	class AnswerAction implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent arg0) {
			Base.open(Config.getInstance().getDriver(), Config.getInstance().getDns(), Config.getInstance().getUser(), Config.getInstance().getPassword());
			LazyList<Model> options = Option.find("question_id = ? AND content = ?", questionId,
					arg0.getActionCommand());
			if (options.size() > 0) {
				Model option = options.get(0);
				ResultQuestion rq = new ResultQuestion();
				rq.testId = testId;
				rq.questionId = questionId;
				rq.questionPos = questionPos;
				rq.havePoint = option.getBoolean("is_correct");
				results.add(rq);
				System.out.println(results);
			}
			Base.close();
			loadNextQuestion();
		}

	}
}
