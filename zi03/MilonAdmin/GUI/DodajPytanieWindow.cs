using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MilonAdmin.GUI {
	public partial class DodajPytanieWindow : Form {
		public DodajPytanieWindow( ) {
			InitializeComponent( );
		}

		private void buttonOk_Click(object sender, EventArgs e) {
			var dataSet = new MilionerzyDataSet( );
			var pytanie = dataSet.Question.NewQuestionRow( );
			pytanie.Content = this.textBoxPytanie.Text;
			dataSet.Question.AddQuestionRow(pytanie);
			if (pytanie.isValid( )) {
				Data.DataProxyDispather.Instance.DataProxy.InsertQuestion(pytanie);
				this.Close( );
			}
		}

		private void buttonAnuluj_Click(object sender, EventArgs e) {
			this.Close( );
		}
	}
}
