using System;
using MilonAdmin.MilionerzyDataSetTableAdapters;

namespace MilonAdmin.Data
{
	internal class ConnectedDataProxy : IDataProxy
	{
		private QuestionsTableAdapter questionTableAdapter;
		private UsersTableAdapter userTableAdapter;

		public ConnectedDataProxy()
		{
			this.questionTableAdapter = new QuestionsTableAdapter();
			this.userTableAdapter = new UsersTableAdapter();
		}

		public void FillQuestions(MilionerzyDataSet.QuestionsDataTable table)
		{
			this.questionTableAdapter.Fill(table);
		}

		public void InsertQuestion(MilionerzyDataSet.QuestionsRow question)
		{
			this.questionTableAdapter.Insert(question.Content);
		}

		public void UpdateQuestion(MilionerzyDataSet.QuestionsRow question)
		{
			this.questionTableAdapter.Update(question);
		}

		public void DeleteQuestion(MilionerzyDataSet.QuestionsRow question)
		{
			this.questionTableAdapter.Delete(question.Id, question.Content);
		}

		public void FillUsers(MilionerzyDataSet.UsersDataTable table)
		{
			this.userTableAdapter.Fill(table);
		}

		public void InsertUser(MilionerzyDataSet.UsersRow user)
		{
			this.userTableAdapter.Insert(user.Login, user.Password, user.Email, user.Birthdate, user.Is_Player, user.Avatar);
		}

		public void UpdateUser(MilionerzyDataSet.UsersRow user)
		{
			this.userTableAdapter.Update(user);
		}

		public void DeleteUser(MilionerzyDataSet.UsersRow user)
		{
			this.userTableAdapter.Delete(user.Id, user.Login, user.Password, user.Email, user.Birthdate, user.Is_Player);
		}

		public void FillOptions(MilionerzyDataSet.OptionsDataTable table)
		{
			throw new NotImplementedException();
		}

		public void InsertOption(MilionerzyDataSet.OptionsRow option)
		{
			throw new NotImplementedException();
		}

		public void UpdateOption(MilionerzyDataSet.OptionsRow option)
		{
			throw new NotImplementedException();
		}

		public void DeleteOption(MilionerzyDataSet.OptionsRow option)
		{
			throw new NotImplementedException();
		}
	}
}
