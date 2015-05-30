package Domain;

import org.javalite.activejdbc.Model;
import org.javalite.activejdbc.annotations.Table;

@Table("question")
public class Question extends Model {
	static{
		validatePresenceOf("content");
	}
	
	public String getContent() {
		return this.getString("content");
	}
}
