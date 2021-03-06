﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MilonAdmin {
	public static class OptionExternalValidator {
		public static bool isValid(this MilionerzyDataSet.OptionsRow option) {
			if (string.IsNullOrEmpty(option.Content)) {
				MessageBox.Show("Treść jest wymagana!");
				return false;
			}
			try {
				if (option.QuestionsRow == null && option.Question_Id <= 0) {
					MessageBox.Show("Pytanie jest wymagane!");
					return false;
				}
			} catch {
				MessageBox.Show("Pytanie jest wymagane!");
				return false;
			}
			return true;
		}
	}
}
