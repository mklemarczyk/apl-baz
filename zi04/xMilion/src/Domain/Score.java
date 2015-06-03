package Domain;

import org.javalite.activejdbc.Model;
import org.javalite.activejdbc.annotations.Table;

@Table("scores")
public class Score extends Model {
	static{
		validatePresenceOf("value", "user_id", "test_id");
	}
	
	public int getValue(){
		return this.getInteger("value");
	}
	public void setValue(int i) {
		this.setInteger("value", i);
	}
	
	public User getUser(){
		return this.parent(User.class);
	}

	public void setTestId(int testId) {
		this.setInteger("test_id", testId);
	}

	public void setUserId(int userId) {
		this.setInteger("user_id", userId);
	}
}
