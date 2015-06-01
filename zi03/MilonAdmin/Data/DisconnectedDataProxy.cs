using System;
using MilonAdmin.MilionerzyDataSetTableAdapters;

namespace MilonAdmin.Data {
	internal class DisconnectedDataProxy : IDataProxy {
		public void FillQuestions(MilionerzyDataSet.QuestionsDataTable table) {
			using (var adapter = new QuestionsTableAdapter( )) {
				adapter.Fill(table);
			}
		}

		public void FillUsers(MilionerzyDataSet.UsersDataTable table) {
			using (var adapter = new UsersTableAdapter( )) {
				adapter.Fill(table);
			}
		}

		public void DeleteQuestion(MilionerzyDataSet.QuestionsRow question) {
			using (var adapter = new QuestionsTableAdapter( )) {
				adapter.Delete(question.Id, question.Content);
			}
		}

		public void DeleteUser(MilionerzyDataSet.UsersRow user) {
			using (var adapter = new UsersTableAdapter( )) {
				adapter.Delete(user.Id, user.Login, user.Password, user.Email, user.Birthdate, user.Is_Player);
			}
		}

		public void InsertQuestion(MilionerzyDataSet.QuestionsRow question) {
			using (var adapter = new QuestionsTableAdapter( )) {
				adapter.Insert(question.Content);
			}
		}

		public void InsertUser(MilionerzyDataSet.UsersRow user) {
			using (var adapter = new UsersTableAdapter( )) {
				adapter.Insert(user.Login, user.Password, user.Email, user.Birthdate, user.Is_Player, user.Avatar);
			}
		}

		public void UpdateQuestion(MilionerzyDataSet.QuestionsRow question) {
			using (var adapter = new QuestionsTableAdapter( )) {
				adapter.Update(question);
			}
		}

		public void UpdateUser(MilionerzyDataSet.UsersRow user) {
			using (var adapter = new UsersTableAdapter( )) {
				adapter.Update(user);
			}
		}

		public void FillOptions(MilionerzyDataSet.OptionsDataTable table) {
			using (var adapter = new OptionsTableAdapter( )) {
				adapter.Fill(table);
			}
		}

		public void InsertOption(MilionerzyDataSet.OptionsRow option) {
			using (var adapter = new OptionsTableAdapter( )) {
				adapter.Update(option);
			}
		}

		public void UpdateOption(MilionerzyDataSet.OptionsRow option) {
			using (var adapter = new OptionsTableAdapter( )) {
				adapter.Update(option);
			}
		}

		public void DeleteOption(MilionerzyDataSet.OptionsRow option) {
			using (var adapter = new OptionsTableAdapter( )) {
				adapter.Update(option);
			}
		}
	}
}