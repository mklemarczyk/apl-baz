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
	public partial class EdytujOdpowiedzWindow : Form {
		private MilionerzyDataSet.OptionsRow _odpowiedz;

		public EdytujOdpowiedzWindow( ) {
			InitializeComponent( );

			var questions = new MilionerzyDataSet.QuestionsDataTable( );
			Data.DataProxyDispather.Instance.DataProxy.FillQuestions(questions);

			this.comboBoxPytanie.DataSource = questions;
			this.comboBoxPytanie.DisplayMember = "Content";
			this.comboBoxPytanie.ValueMember = "Id";
        }

		private void buttonOk_Click(object sender, EventArgs e) {
			var pytanie = DataFinder.DiscoverData<MilionerzyDataSet.QuestionsRow>(this.comboBoxPytanie.SelectedItem);
			if (pytanie != null) {
				_odpowiedz.Question_Id = pytanie.Id;
			}
			_odpowiedz.Content = this.textBoxOdpowiedz.Text;
			if (this._odpowiedz.isValid( )) {
				Data.DataProxyDispather.Instance.DataProxy.UpdateOption(this._odpowiedz);
				this.Close( );
			}
		}

		private void buttonAnuluj_Click(object sender, EventArgs e) {
			this.Close( );
		}

		public void ShowDialog(MilionerzyDataSet.OptionsRow odpowiedz) {
			this._odpowiedz = odpowiedz;
			this.comboBoxPytanie.SelectedValue = this._odpowiedz.Question_Id;
			this.textBoxOdpowiedz.Text = this._odpowiedz.Content;
			ShowDialog( );
		}
	}
}
