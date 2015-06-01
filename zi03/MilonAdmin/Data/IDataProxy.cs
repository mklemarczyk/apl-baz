using System;
using System.Collections.Generic;
using System.Text;

namespace MilonAdmin.Data {
	public interface IDataProxy {
		void FillOptions(MilionerzyDataSet.OptionsDataTable table);

		void InsertOption(MilionerzyDataSet.OptionsRow option);

		void UpdateOption(MilionerzyDataSet.OptionsRow option);

		void DeleteOption(MilionerzyDataSet.OptionsRow option);

		void FillQuestions(MilionerzyDataSet.QuestionsDataTable table);

		void InsertQuestion(MilionerzyDataSet.QuestionsRow question);

		void UpdateQuestion(MilionerzyDataSet.QuestionsRow question);

		void DeleteQuestion(MilionerzyDataSet.QuestionsRow question);

		void FillUsers(MilionerzyDataSet.UsersDataTable table);

		void InsertUser(MilionerzyDataSet.UsersRow user);

		void UpdateUser(MilionerzyDataSet.UsersRow user);

		void DeleteUser(MilionerzyDataSet.UsersRow user);
	}
}
