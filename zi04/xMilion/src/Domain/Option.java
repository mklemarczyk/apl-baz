package Domain;

import org.javalite.activejdbc.Model;
import org.javalite.activejdbc.annotations.Table;

@Table("options")
public class Option extends Model {
	static{
		validatePresenceOf("content", "is_correct", "question_id");
	}
	
	public String getContent() {
		return this.getString("content");
	}

	public boolean getIsCorrect() {
		return this.getBoolean("is_correct");
	}
}
