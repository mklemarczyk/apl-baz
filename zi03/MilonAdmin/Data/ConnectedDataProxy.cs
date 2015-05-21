using System;
using MilonAdmin.MilionerzyDataSetTableAdapters;

namespace MilonAdmin.Data {
	internal class ConnectedDataProxy : IDataProxy {
		private QuestionTableAdapter questionTableAdapter;
		private UserTableAdapter userTableAdapter;

		public ConnectedDataProxy( ) {
			this.questionTableAdapter = new QuestionTableAdapter( );
			this.userTableAdapter = new UserTableAdapter( );
		}

		public void FillQuestions(MilionerzyDataSet.QuestionDataTable table) {
			this.questionTableAdapter.Fill(table);
		}

		public void InsertQuestion(MilionerzyDataSet.QuestionRow question) {
			this.questionTableAdapter.Insert(question.Content);
		}

		public void UpdateQuestion(MilionerzyDataSet.QuestionRow question) {
			this.questionTableAdapter.Update(question);
		}

		public void DeleteQuestion(MilionerzyDataSet.QuestionRow question) {
			this.questionTableAdapter.Delete(question.Id, question.Content);
		}

		public void FillUsers(MilionerzyDataSet.UserDataTable table) {
			this.userTableAdapter.Fill(table);
		}

		public void InsertUser(MilionerzyDataSet.UserRow user) {
			this.userTableAdapter.Insert(user.Login, user.Password, user.Email, user.Birthdate, user.IsPlayer, user.Avatar);
		}

		public void UpdateUser(MilionerzyDataSet.UserRow user) {
			this.userTableAdapter.Update(user);
		}

		public void DeleteUser(MilionerzyDataSet.UserRow user) {
			this.userTableAdapter.Delete(user.Id, user.Login, user.Password, user.Email, user.Birthdate, user.IsPlayer);
		}

		public void FillOptions(MilionerzyDataSet.OptionDataTable table) {
			throw new NotImplementedException( );
		}

		public void InsertOption(MilionerzyDataSet.OptionRow option) {
			throw new NotImplementedException( );
		}

		public void UpdateOption(MilionerzyDataSet.OptionRow option) {
			throw new NotImplementedException( );
		}

		public void DeleteOption(MilionerzyDataSet.OptionRow option) {
			throw new NotImplementedException( );
		}
	}
}