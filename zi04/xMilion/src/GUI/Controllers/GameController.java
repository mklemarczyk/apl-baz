package GUI.Controllers;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Random;
import java.util.Timer;
import java.util.TimerTask;

import org.javalite.activejdbc.Base;
import org.javalite.activejdbc.LazyList;

import Domain.Config;
import Domain.Game;
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

	Game game;
	Timer timer;

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
	public void setGame(Game game) {
		this.game = game;
		loadNextQuestion();
	}

	@Override
	public void loadNewTest() {
		Base.open(Config.getInstance().getDriver(), Config.getInstance().getDns(), Config.getInstance().getUser(),
				Config.getInstance().getPassword());

		LazyList<Question> questions = Question.findAll();
		int range = questions.size();

		if (range > 0) {
			Test test = new Test();
			test.setUserId(1);
			test.saveIt();

			Random rand = new Random();

			for (int i = 0; i < Game.qustionsCount; i++) {
				int randInt = rand.nextInt(range);
				Question question = questions.get(randInt);
				TestItem testItem = new TestItem();
				testItem.setTest(test);
				testItem.setQuestion(question);
				testItem.saveIt();
			}

			this.game = new Game(test.getInteger("id"));
		}
		Base.close();

		this.loadNextQuestion();
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
		this.game.time = 60;
		_view.setTime(this.game.time);
		if (this.timer != null) {
			this.timer.cancel();
		}
		this.timer = new Timer();
		this.timer.scheduleAtFixedRate(new TimerTask() {
			@Override
			public void run() {
				if (game.time > 1) {
					game.time--;
					_view.setTime(game.time);
				} else {
					game.lastResult = false;
					loadNextQuestion();
				}
			}
		}, 1000, 1000);
	}

	private void loadNextQuestion() {
		if (game != null) {
			if (game.lastResult == false) {
				mainController.getView().setState(MainState.EndGameFailed);
				this.timer.cancel();
			} else {
				game.currentQuestionPos++;
				Base.open(Config.getInstance().getDriver(), Config.getInstance().getDns(), Config.getInstance()
						.getUser(), Config.getInstance().getPassword());
				LazyList<TestItem> testItems = TestItem.find("test_id = ?", game.testId);
				if (game.currentQuestionPos < testItems.size()) {
					TestItem testItem = testItems.get(game.currentQuestionPos);
					int questionId = testItem.getQuestionId();
					this.game.currentQuestionId = questionId;

					Question question = Question.findById(questionId);
					this._view.setQuestion(question.getContent());

					LazyList<Option> options = Option.where("question_id = ?", questionId);
					this._view.setOptions(options.get(0).getContent(), options.get(1).getContent(), options.get(2)
							.getContent(), options.get(3).getContent());

				} else {
					mainController.getView().setState(MainState.EndGameSuccess);
				}
				Base.close();
			}
			restartTimer();
		}
	}

	class CancelAction implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent arg0) {
			if (game != null) {
				game.saveState();
			}
			if (timer != null) {
				timer.cancel();
			}
			mainController.getView().setState(MainState.Menu);
		}

	}

	class AnswerAction implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent arg0) {
			Base.open(Config.getInstance().getDriver(), Config.getInstance().getDns(), Config.getInstance().getUser(),
					Config.getInstance().getPassword());
			LazyList<Option> options = Option.find("question_id = ? AND content = ?", game.currentQuestionId,
					arg0.getActionCommand());
			if (options.size() > 0) {
				Option option = options.get(0);
				ResultQuestion rq = new ResultQuestion();
				rq.testId = game.testId;
				rq.questionId = game.currentQuestionId;
				rq.questionPos = game.currentQuestionPos;
				rq.havePoint = option.getBoolean("is_correct");
				game.results.add(rq);
			}
			Base.close();
			loadNextQuestion();
		}

	}
}
