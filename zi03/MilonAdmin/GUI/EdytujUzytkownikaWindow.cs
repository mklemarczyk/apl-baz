using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MilonAdmin.GUI {
	public partial class EdytujUzytkownikaWindow : Form {
		private MilionerzyDataSet.UserRow _uzytkownik;

		public EdytujUzytkownikaWindow( ) {
			InitializeComponent( );
		}

		private void buttonOk_Click(object sender, EventArgs e) {
			this._uzytkownik.Login = this.textBoxLogin.Text;
			this._uzytkownik.Password = this.maskedTextBoxHaslo.Text;
			this._uzytkownik.Email = this.textBoxEmail.Text;
			this._uzytkownik.Birthdate = this.dateTimePickerDataUrodzenia.Value.Date;
			this._uzytkownik.IsPlayer = this.checkBoxAktywnosc.Checked;
			if (this._uzytkownik.isValid( )) {
				Data.DataProxyDispather.Instance.DataProxy.UpdateUser(this._uzytkownik);
				this.Close( );
			}
		}

		private void buttonAnuluj_Click(object sender, EventArgs e) {
			this.Close( );
		}

		public void ShowDialog(MilionerzyDataSet.UserRow uzytkownik) {
			this._uzytkownik = uzytkownik;
			this.textBoxLogin.Text = this._uzytkownik.Login;
			this.maskedTextBoxHaslo.Text = this._uzytkownik.Password;
			this.textBoxEmail.Text = this._uzytkownik.Email;
			this.dateTimePickerDataUrodzenia.Value = this._uzytkownik.Birthdate;
			this.checkBoxAktywnosc.Checked = this._uzytkownik.IsPlayer;
			ShowDialog( );
		}
	}
}
