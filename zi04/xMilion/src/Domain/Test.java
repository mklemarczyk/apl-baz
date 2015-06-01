package Domain;

import org.javalite.activejdbc.Model;
import org.javalite.activejdbc.annotations.Table;

@Table("tests")
public class Test extends Model {
	static{
		validatePresenceOf("user_id");
	}

	public void setUserId(int id) {
		this.setInteger("user_id", id);
	}
	
}
