package GUI.Controllers;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;
import java.util.List;
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
import Domain.Score;
import Domain.Test;
import Domain.TestItem;
import Domain.User;
import GUI.Interface.IGameController;
import GUI.Interface.IGameView;
import GUI.Interface.IMainController;
import GUI.Interface.IMainController.MainState;

public final class GameController implements IGameController {
	IGameView _view;
	IMainController mainController;

	Game game;
	Timer timer;

	int correctId;
	int[] answerId = new int[4];

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

		List<Question> questions = new ArrayList<Question>(Question.findAll());
		int range = questions.size();

		if (range > 0) {
			Test test = new Test();
			test.setUserId(1);
			test.saveIt();

			Random rand = new Random();

			for (int i = 0; i < Game.qustionsCount; i++) {
				int randInt = rand.nextInt(range);
				Question question = questions.get(randInt);
				questions.remove(randInt);
				TestItem testItem = new TestItem();
				testItem.setTest(test);
				testItem.setQuestion(question);
				testItem.saveIt();
				range--;
			}

			List<User> users = User.find("login = ? AND password = ?", Config.getInstance().getUserLogin(), Config
					.getInstance().getUserPassword());
			if (!users.isEmpty()) {
				User user = users.get(0);
				this.game = new Game(test.getInteger("id"), (int) user.getId());
			}
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
	
	@Override
	public ActionListener getAnswer1Event() {
		return new Answer1Action();
	}
	
	@Override
	public ActionListener getAnswer2Event() {
		return new Answer2Action();
	}
	
	@Override
	public ActionListener getAnswer3Event() {
		return new Answer3Action();
	}
	
	@Override
	public ActionListener getAnswer4Event() {
		return new Answer4Action();
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
				if (game != null) {
					if (game.time > 1) {
						game.time--;
						_view.setTime(game.time);
					} else {
						game.lastResult = false;
						loadNextQuestion();
					}
				}
			}
		}, 1000, 1000);
	}

	private void loadNextQuestion() {
		if (game != null) {
			if (game.lastResult == false) {
				this.timer.cancel();
				Base.open(Config.getInstance().getDriver(), Config.getInstance().getDns(), Config.getInstance()
						.getUser(), Config.getInstance().getPassword());

				Score score = new Score();
				score.setValue(this.game.getPrice());
				score.setTestId(this.game.testId);
				score.setUserId(this.game.userId);
				score.saveIt();

				Base.close();
				this.mainController.showEndGame(this.game);
				this.game = null;

			} else {
				game.currentQuestionPos++;
				Base.open(Config.getInstance().getDriver(), Config.getInstance().getDns(), Config.getInstance()
						.getUser(), Config.getInstance().getPassword());
				LazyList<TestItem> testItems = TestItem.find("test_id = ?", game.testId);
				if (game.currentQuestionPos < testItems.size() && game.currentQuestionPos < Game.prices.length) {
					TestItem testItem = testItems.get(game.currentQuestionPos);
					int questionId = testItem.getQuestionId();
					this.game.currentQuestionId = questionId;

					Question question = Question.findById(questionId);
					this._view.setQuestion(question.getContent());

					LazyList<Option> options = Option.where("question_id = ?", questionId);
					this._view.setOptions(options.get(0).getContent(), options.get(1).getContent(), options.get(2)
							.getContent(), options.get(3).getContent());

					for (int i = 0; i < 4; i++) {
						if (options.get(i).getIsCorrect()) {
							this.correctId = (int) options.get(i).getId();
						}
						this.answerId[i] = (int) options.get(i).getId();
					}

					this._view.setPrice(Game.prices[game.currentQuestionPos]);

					restartTimer();
				} else {
					this.mainController.showEndGame(this.game);
					this.game = null;
				}
				Base.close();
			}
		} else {
			mainController.getView().setState(MainState.Menu);
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

	private void checkOption(int i){
		Base.open(Config.getInstance().getDriver(), Config.getInstance().getDns(), Config.getInstance().getUser(),
				Config.getInstance().getPassword());
		LazyList<Option> options = Option.find("question_id = ? AND id = ?", game.currentQuestionId, this.answerId[i]);
		ResultQuestion rq = new ResultQuestion();
		rq.testId = game.testId;
		rq.questionId = game.currentQuestionId;
		rq.questionPos = game.currentQuestionPos;
		if (options.size() > 0) {
			Option option = options.get(0);
			rq.havePoint = option.getIsCorrect();
		} else {
			System.out.println(String.format("Warning %d", i));
		}
		game.lastResult = rq.havePoint;
		game.results.add(rq);
		Base.close();
		loadNextQuestion();
	}
	
	class AnswerAction implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent arg0) {
			Base.open(Config.getInstance().getDriver(), Config.getInstance().getDns(), Config.getInstance().getUser(),
					Config.getInstance().getPassword());
			LazyList<Option> options = Option.find("question_id = ? AND id = ?", game.currentQuestionId, correctId);
			ResultQuestion rq = new ResultQuestion();
			rq.testId = game.testId;
			rq.questionId = game.currentQuestionId;
			rq.questionPos = game.currentQuestionPos;
			if (options.size() > 0) {
				Option option = options.get(0);
				rq.havePoint = option.getIsCorrect();
			} else {
				System.out.println(arg0.getActionCommand());
			}
			game.lastResult = rq.havePoint;
			game.results.add(rq);
			Base.close();
			loadNextQuestion();
		}
	}
	
	class Answer1Action implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent arg0) {
			checkOption(0);
		}
	}
	
	class Answer2Action implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent arg0) {
			checkOption(1);
		}
	}
	
	class Answer3Action implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent arg0) {
			checkOption(2);
		}
	}
	
	class Answer4Action implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent arg0) {
			checkOption(3);
		}
	}
}
