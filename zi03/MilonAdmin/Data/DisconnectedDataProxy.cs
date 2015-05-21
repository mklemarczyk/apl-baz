using System;
using MilonAdmin.MilionerzyDataSetTableAdapters;

namespace MilonAdmin.Data {
	internal class DisconnectedDataProxy : IDataProxy {
		public void FillQuestions(MilionerzyDataSet.QuestionDataTable table) {
			using (var adapter = new QuestionTableAdapter( )) {
				adapter.Fill(table);
			}
		}

		public void FillUsers(MilionerzyDataSet.UserDataTable table) {
			using (var adapter = new UserTableAdapter( )) {
				adapter.Fill(table);
			}
		}

		public void DeleteQuestion(MilionerzyDataSet.QuestionRow question) {
			using (var adapter = new QuestionTableAdapter( )) {
				adapter.Delete(question.Id, question.Content);
			}
		}

		public void DeleteUser(MilionerzyDataSet.UserRow user) {
			using (var adapter = new UserTableAdapter( )) {
				adapter.Delete(user.Id, user.Login, user.Password, user.Email, user.Birthdate, user.IsPlayer);
			}
		}

		public void InsertQuestion(MilionerzyDataSet.QuestionRow question) {
			using (var adapter = new QuestionTableAdapter( )) {
				adapter.Insert(question.Content);
			}
		}

		public void InsertUser(MilionerzyDataSet.UserRow user) {
			using (var adapter = new UserTableAdapter( )) {
				adapter.Insert(user.Login, user.Password, user.Email, user.Birthdate, user.IsPlayer, user.Avatar);
			}
		}

		public void UpdateQuestion(MilionerzyDataSet.QuestionRow question) {
			using (var adapter = new QuestionTableAdapter( )) {
				adapter.Update(question);
			}
		}

		public void UpdateUser(MilionerzyDataSet.UserRow user) {
			using (var adapter = new UserTableAdapter( )) {
				adapter.Update(user);
			}
		}

		public void FillOptions(MilionerzyDataSet.OptionDataTable table) {
			using (var adapter = new OptionTableAdapter( )) {
				adapter.Fill(table);
			}
		}

		public void InsertOption(MilionerzyDataSet.OptionRow option) {
			using (var adapter = new OptionTableAdapter( )) {
				adapter.Update(option);
			}
		}

		public void UpdateOption(MilionerzyDataSet.OptionRow option) {
			using (var adapter = new OptionTableAdapter( )) {
				adapter.Update(option);
			}
		}

		public void DeleteOption(MilionerzyDataSet.OptionRow option) {
			using (var adapter = new OptionTableAdapter( )) {
				adapter.Update(option);
			}
		}
	}
}