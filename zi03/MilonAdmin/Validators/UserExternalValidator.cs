using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MilonAdmin {
	public static class UserExternalValidator {
		public static bool isValid(this MilionerzyDataSet.UserRow user) {
			if (string.IsNullOrEmpty(user.Login)) {
				MessageBox.Show("Login jest wymagany!");
				return false;
			}
			if (string.IsNullOrEmpty(user.Password)) {
				MessageBox.Show("Hasło jest wymagane!");
				return false;
			}
			if (string.IsNullOrEmpty(user.Email)) {
				MessageBox.Show("Email jest wymagany!");
				return false;
			}
			if (string.IsNullOrEmpty(user.Email)) {
				MessageBox.Show("Login jest wymagany!");
				return false;
			}
			if (!Regex.IsMatch(user.Email, @"(\w+@\w+(\.\w+)+)")) {
				MessageBox.Show("Błędny format maila!");
				return false;
			}
			return true;
		}
	}
}
