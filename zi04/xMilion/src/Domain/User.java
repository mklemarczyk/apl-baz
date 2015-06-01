package Domain;

import org.javalite.activejdbc.Model;
import org.javalite.activejdbc.annotations.Table;

@Table("users")
public class User extends Model {
	static{
		validatePresenceOf("login", "password", "email", "birthdate", "is_player");
	}
	
	public String getLogin(){
		return this.getString("login");
	}

	public String getEmail(){
		return this.getString("email");
	}
}
