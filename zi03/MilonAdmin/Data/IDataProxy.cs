using System;
using System.Collections.Generic;
using System.Text;

namespace MilonAdmin.Data {
	public interface IDataProxy {
		void FillOptions(MilionerzyDataSet.OptionDataTable table);

		void InsertOption(MilionerzyDataSet.OptionRow option);

		void UpdateOption(MilionerzyDataSet.OptionRow option);

		void DeleteOption(MilionerzyDataSet.OptionRow option);

		void FillQuestions(MilionerzyDataSet.QuestionDataTable table);

		void InsertQuestion(MilionerzyDataSet.QuestionRow question);

		void UpdateQuestion(MilionerzyDataSet.QuestionRow question);

		void DeleteQuestion(MilionerzyDataSet.QuestionRow question);

		void FillUsers(MilionerzyDataSet.UserDataTable table);

		void InsertUser(MilionerzyDataSet.UserRow user);

		void UpdateUser(MilionerzyDataSet.UserRow user);

		void DeleteUser(MilionerzyDataSet.UserRow user);
	}
}
