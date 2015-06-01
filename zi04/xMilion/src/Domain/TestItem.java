package Domain;

import org.javalite.activejdbc.Model;
import org.javalite.activejdbc.annotations.Table;

@Table("test_items")
public class TestItem extends Model {
	static{
		validatePresenceOf("test_id", "question_id");
	}

	public int getQuestionId() {
		return this.getInteger("question_id");
	}

	public void setTest(Test test) {
		this.set("test_id", test.getId());
	}

	public void setQuestion(Question question) {
		this.set("question_id", question.getId());
	}

}
