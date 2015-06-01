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
	
	public User getUser(){
		return this.parent(User.class);
	}
}
