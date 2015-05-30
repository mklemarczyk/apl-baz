package Domain;

import org.javalite.activejdbc.Model;
import org.javalite.activejdbc.annotations.Table;

@Table("score")
public class Score extends Model {
	static{
		validatePresenceOf("value", "user_id", "test_id");
	}
}
