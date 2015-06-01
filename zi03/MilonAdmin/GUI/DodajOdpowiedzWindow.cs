using MilonAdmin.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MilonAdmin.GUI {
	public partial class DodajOdpowiedzWindow : Form {
		public DodajOdpowiedzWindow( ) {
			InitializeComponent( );

			var questions = new MilionerzyDataSet.QuestionsDataTable( );
			Data.DataProxyDispather.Instance.DataProxy.FillQuestions(questions);

			this.comboBoxPytanie.DataSource = questions;
			this.comboBoxPytanie.DisplayMember = "Content";
		}

		private void buttonOk_Click(object sender, EventArgs e) {
			var dataSet = new MilionerzyDataSet( );
			var odpowiedz = dataSet.Options.NewOptionsRow( );
			var pytanie = DataFinder.DiscoverData<MilionerzyDataSet.QuestionsRow>(this.comboBoxPytanie.SelectedItem);
			if (pytanie != null) {
				odpowiedz.Question_Id = pytanie.Id;
			}
			odpowiedz.Content = this.textBoxOdpowiedz.Text;
			dataSet.Options.AddOptionsRow(odpowiedz);
			if (odpowiedz.isValid( )) {
				Data.DataProxyDispather.Instance.DataProxy.InsertOption(odpowiedz);
				this.Close( );
			}
		}

		private void buttonAnuluj_Click(object sender, EventArgs e) {
			this.Close( );
		}
	}
}
