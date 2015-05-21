using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MilonAdmin.GUI {
	public partial class DodajUzytkownikaWindow : Form {
		public DodajUzytkownikaWindow( ) {
			InitializeComponent( );
			this.dateTimePickerDataUrodzenia.MaxDate = DateTime.Now.Date;
		}

		private void buttonOk_Click(object sender, EventArgs e) {
			var dataSet = new MilionerzyDataSet( );
			var uzytkownik = dataSet.User.NewUserRow( );
			uzytkownik.Login = this.textBoxLogin.Text;
			uzytkownik.Password = this.maskedTextBoxHaslo.Text;
			uzytkownik.Email = this.textBoxEmail.Text;
			uzytkownik.Birthdate = this.dateTimePickerDataUrodzenia.Value.Date;
			uzytkownik.IsPlayer = this.checkBoxAktywnosc.Checked;
			dataSet.User.AddUserRow(uzytkownik);
			if (uzytkownik.isValid( )) {
				Data.DataProxyDispather.Instance.DataProxy.InsertUser(uzytkownik);
				this.Close( );
			}
		}

		private void buttonAnuluj_Click(object sender, EventArgs e) {
			this.Close( );
		}
	}
}
