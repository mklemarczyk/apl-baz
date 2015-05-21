using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MilonAdmin.GUI {
	public partial class EdytujPytanieWindow : Form {
		private MilionerzyDataSet.QuestionRow _pytanie;

		public EdytujPytanieWindow( ) {
			InitializeComponent( );
		}

		private void buttonOk_Click(object sender, EventArgs e) {
			this._pytanie.Content = this.textBoxPytanie.Text;
			if (this._pytanie.isValid( )) {
				Data.DataProxyDispather.Instance.DataProxy.UpdateQuestion(this._pytanie);
				this.Close( );
			}
		}

		private void buttonAnuluj_Click(object sender, EventArgs e) {
			this.Close( );
		}

		public void ShowDialog(MilionerzyDataSet.QuestionRow pytanie) {
			this._pytanie = pytanie;
			this.textBoxPytanie.Text = this._pytanie.Content;
			ShowDialog( );
		}
	}
}
