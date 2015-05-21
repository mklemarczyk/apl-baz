using MilonAdmin.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MilonAdmin.GUI {
	public partial class MainWindow : Form {
		private readonly string _title = "Milion Admin - {0}";

		public MainWindow( ) {
			InitializeComponent( );

			this.UpdateTitle( );
		}

		#region Uzytkownik
		private void buttonUzytkownikDodaj_Click(object sender, EventArgs e) {
			DodajUzytkownikaWindow okno = new DodajUzytkownikaWindow( );
			okno.ShowDialog( );
			RefreshUzytkownicy( );
		}

		private void buttonUzytkownikEdytuj_Click(object sender, EventArgs e) {
			if (this.dataGridViewUzytkownicy.SelectedRows.Count > 0) {
				var uzytkownik = DataFinder.DiscoverData<MilionerzyDataSet.UserRow>(this.dataGridViewUzytkownicy.SelectedRows[0]);
				if (uzytkownik != null) {
					EdytujUzytkownikaWindow okno = new EdytujUzytkownikaWindow( );
					okno.ShowDialog(uzytkownik);
					RefreshUzytkownicy( );
				}
			}
		}

		private void buttonUzytkownikUsun_Click(object sender, EventArgs e) {
			if (this.dataGridViewUzytkownicy.SelectedRows.Count > 0) {
				if (MessageBox.Show("Czy na pewno chcesz uzunac?", "Uwaga", MessageBoxButtons.OKCancel) == DialogResult.OK) {
					foreach (DataGridViewRow row in this.dataGridViewUzytkownicy.SelectedRows) {
						var user = DataFinder.DiscoverData<MilionerzyDataSet.UserRow>(row);
						if (user != null) {
							Data.DataProxyDispather.Instance.DataProxy.DeleteUser(user);
							RefreshUzytkownicy( );
						}
					}
				}
			}
		}

		private void buttonUzytkownikOdswiez_Click(object sender, EventArgs e) {
			RefreshUzytkownicy( );
		}

		private void RefreshUzytkownicy( ) {
			Data.DataProxyDispather.Instance.DataProxy.FillUsers(this.milionerzyDataSet.User);
		}

		private void buttonDodajObrazek_Click(object sender, EventArgs e) {
			if (this.dataGridViewUzytkownicy.SelectedRows.Count > 0) {
				var uzytkownik = DataFinder.DiscoverData<MilionerzyDataSet.UserRow>(this.dataGridViewUzytkownicy.SelectedRows[0]);
				if (uzytkownik != null) {
					if (openFileDialogObrazek.ShowDialog( ) == DialogResult.OK) {
						if (openFileDialogObrazek.CheckFileExists) {
							using (var file = openFileDialogObrazek.OpenFile( )) {
								List<byte> data = new List<byte>( );
								var dataPart = file.ReadByte( );
								while (dataPart > -1) {
									data.Add((byte)dataPart);
									dataPart = file.ReadByte( );
								}
								uzytkownik.Avatar = data.ToArray( );
								Data.DataProxyDispather.Instance.DataProxy.UpdateUser(uzytkownik);
							}
						}
					}
				}
			}
		}
		#endregion

		#region Pytanie
		private void buttonPytanieDodaj_Click(object sender, EventArgs e) {
			DodajPytanieWindow okno = new DodajPytanieWindow( );
			okno.ShowDialog( );
			RefreshPytania( );
		}

		private void buttonPytanieEdytuj_Click(object sender, EventArgs e) {
			if (this.dataGridViewPytania.SelectedRows.Count > 0) {
				var pytanie = DataFinder.DiscoverData<MilionerzyDataSet.QuestionRow>(this.dataGridViewPytania.SelectedRows[0]);
				if (pytanie != null) {
					EdytujPytanieWindow okno = new EdytujPytanieWindow( );
					okno.ShowDialog(pytanie);
					RefreshPytania( );
				}
			}
		}

		private void buttonPytanieUsun_Click(object sender, EventArgs e) {
			if (this.dataGridViewPytania.SelectedRows.Count > 0) {
				if (MessageBox.Show("Czy na pewno chcesz usunac?", "Uwaga", MessageBoxButtons.OKCancel) == DialogResult.OK) {
					foreach (DataGridViewRow row in this.dataGridViewPytania.SelectedRows) {
						var question = DataFinder.DiscoverData<MilionerzyDataSet.QuestionRow>(row);
						if (question != null) {
							Data.DataProxyDispather.Instance.DataProxy.DeleteQuestion(question);
							RefreshPytania( );
						}
					}
				}
			}
		}

		private void buttonPytanieOdswiez_Click(object sender, EventArgs e) {
			RefreshPytania( );
		}

		private void RefreshPytania( ) {
			Data.DataProxyDispather.Instance.DataProxy.FillQuestions(this.milionerzyDataSet.Question);
		}
		#endregion

		#region Odpowiedz
		private void buttonOdpowiedzDodaj_Click(object sender, EventArgs e) {
			DodajOdpowiedzWindow okno = new DodajOdpowiedzWindow( );
			okno.ShowDialog( );
			RefreshOdpowiedzi( );
		}

		private void buttonOdpowiedzEdytuj_Click(object sender, EventArgs e) {
			if (this.dataGridViewOdpowiedzi.SelectedRows.Count > 0) {
				var option = DataFinder.DiscoverData<MilionerzyDataSet.OptionRow>(this.dataGridViewOdpowiedzi.SelectedRows[0]);
				if (option != null) {
					EdytujOdpowiedzWindow okno = new EdytujOdpowiedzWindow( );
					okno.ShowDialog(option);
					RefreshOdpowiedzi( );
				}
			}
		}

		private void buttonOdpowiedzUsun_Click(object sender, EventArgs e) {
			if (this.dataGridViewOdpowiedzi.SelectedRows.Count > 0) {
				if (MessageBox.Show("Czy na pewno chcesz usunac?", "Uwaga", MessageBoxButtons.OKCancel) == DialogResult.OK) {
					foreach (DataGridViewRow row in this.dataGridViewOdpowiedzi.SelectedRows) {
						var option = DataFinder.DiscoverData<MilionerzyDataSet.OptionRow>(row);
						if (option != null) {
							Data.DataProxyDispather.Instance.DataProxy.DeleteOption(option);
							RefreshOdpowiedzi( );
						}
					}
				}
			}
		}

		private void buttonOdpowiedzOdswiez_Click(object sender, EventArgs e) {
			RefreshOdpowiedzi( );
		}

		private void RefreshOdpowiedzi( ) {
			Data.DataProxyDispather.Instance.DataProxy.FillOptions(this.milionerzyDataSet.Option);
		}
		#endregion

		private void UpdateTitle( ) {
			this.Text = string.Format(this._title, Data.DataProxyDispather.Instance.Mode.ToString( ));
		}

		private void MainWindow_Load(object sender, EventArgs e) {
			Data.DataProxyDispather.Instance.DataProxy.FillOptions(this.milionerzyDataSet.Option);
			Data.DataProxyDispather.Instance.DataProxy.FillQuestions(this.milionerzyDataSet.Question);
			Data.DataProxyDispather.Instance.DataProxy.FillUsers(this.milionerzyDataSet.User);
		}

		private void buttonSave_Click(object sender, EventArgs e) {
			if (this.checkBoxConnectionMode.Checked) {
				Data.DataProxyDispather.Instance.Mode = Data.ConnectionMode.Polaczeniowy;
			} else {
				Data.DataProxyDispather.Instance.Mode = Data.ConnectionMode.Bezpolaczeniowy;
			}
			this.UpdateTitle( );
        }
	}
}
