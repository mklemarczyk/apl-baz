using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MilonAdmin {
	public static class QuestionExternalValidator {
		public static bool isValid(this MilionerzyDataSet.QuestionsRow question) {
			if (string.IsNullOrEmpty(question.Content)) {
				MessageBox.Show("Treść pytania jest wymagana!");
				return false;
			}
			return true;
		}
	}
}
