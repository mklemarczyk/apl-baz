namespace MilonAdmin.GUI {
	partial class DodajUzytkownikaWindow {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose( );
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( ) {
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanelEtykiety = new System.Windows.Forms.FlowLayoutPanel();
			this.labelLogin = new System.Windows.Forms.Label();
			this.labelHaslo = new System.Windows.Forms.Label();
			this.labelEmail = new System.Windows.Forms.Label();
			this.labelDataUrodzenia = new System.Windows.Forms.Label();
			this.labelAktywnosc = new System.Windows.Forms.Label();
			this.flowLayoutPanelPola = new System.Windows.Forms.FlowLayoutPanel();
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.maskedTextBoxHaslo = new System.Windows.Forms.MaskedTextBox();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.dateTimePickerDataUrodzenia = new System.Windows.Forms.DateTimePicker();
			this.checkBoxAktywnosc = new System.Windows.Forms.CheckBox();
			this.flowLayoutPanelOk = new System.Windows.Forms.FlowLayoutPanel();
			this.buttonOk = new System.Windows.Forms.Button();
			this.flowLayoutPanelAnuluj = new System.Windows.Forms.FlowLayoutPanel();
			this.buttonAnuluj = new System.Windows.Forms.Button();
			this.tableLayoutPanel.SuspendLayout();
			this.flowLayoutPanelEtykiety.SuspendLayout();
			this.flowLayoutPanelPola.SuspendLayout();
			this.flowLayoutPanelOk.SuspendLayout();
			this.flowLayoutPanelAnuluj.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.Controls.Add(this.flowLayoutPanelEtykiety, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.flowLayoutPanelPola, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.flowLayoutPanelOk, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.flowLayoutPanelAnuluj, 1, 1);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 2;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(317, 180);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// flowLayoutPanelEtykiety
			// 
			this.flowLayoutPanelEtykiety.Controls.Add(this.labelLogin);
			this.flowLayoutPanelEtykiety.Controls.Add(this.labelHaslo);
			this.flowLayoutPanelEtykiety.Controls.Add(this.labelEmail);
			this.flowLayoutPanelEtykiety.Controls.Add(this.labelDataUrodzenia);
			this.flowLayoutPanelEtykiety.Controls.Add(this.labelAktywnosc);
			this.flowLayoutPanelEtykiety.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanelEtykiety.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanelEtykiety.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanelEtykiety.Name = "flowLayoutPanelEtykiety";
			this.flowLayoutPanelEtykiety.Size = new System.Drawing.Size(94, 139);
			this.flowLayoutPanelEtykiety.TabIndex = 0;
			// 
			// labelLogin
			// 
			this.labelLogin.AutoSize = true;
			this.labelLogin.Location = new System.Drawing.Point(3, 3);
			this.labelLogin.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.labelLogin.Name = "labelLogin";
			this.labelLogin.Padding = new System.Windows.Forms.Padding(0, 4, 0, 3);
			this.labelLogin.Size = new System.Drawing.Size(33, 20);
			this.labelLogin.TabIndex = 0;
			this.labelLogin.Text = "Login";
			// 
			// labelHaslo
			// 
			this.labelHaslo.AutoSize = true;
			this.labelHaslo.Location = new System.Drawing.Point(3, 28);
			this.labelHaslo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.labelHaslo.Name = "labelHaslo";
			this.labelHaslo.Padding = new System.Windows.Forms.Padding(0, 4, 0, 3);
			this.labelHaslo.Size = new System.Drawing.Size(36, 20);
			this.labelHaslo.TabIndex = 1;
			this.labelHaslo.Text = "Hasło";
			// 
			// labelEmail
			// 
			this.labelEmail.AutoSize = true;
			this.labelEmail.Location = new System.Drawing.Point(3, 53);
			this.labelEmail.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Padding = new System.Windows.Forms.Padding(0, 4, 0, 3);
			this.labelEmail.Size = new System.Drawing.Size(32, 20);
			this.labelEmail.TabIndex = 2;
			this.labelEmail.Text = "Email";
			// 
			// labelDataUrodzenia
			// 
			this.labelDataUrodzenia.AutoSize = true;
			this.labelDataUrodzenia.Location = new System.Drawing.Point(3, 78);
			this.labelDataUrodzenia.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.labelDataUrodzenia.Name = "labelDataUrodzenia";
			this.labelDataUrodzenia.Padding = new System.Windows.Forms.Padding(0, 4, 0, 3);
			this.labelDataUrodzenia.Size = new System.Drawing.Size(79, 20);
			this.labelDataUrodzenia.TabIndex = 3;
			this.labelDataUrodzenia.Text = "Data urodzenia";
			// 
			// labelAktywnosc
			// 
			this.labelAktywnosc.AutoSize = true;
			this.labelAktywnosc.Location = new System.Drawing.Point(3, 103);
			this.labelAktywnosc.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.labelAktywnosc.Name = "labelAktywnosc";
			this.labelAktywnosc.Padding = new System.Windows.Forms.Padding(0, 4, 0, 3);
			this.labelAktywnosc.Size = new System.Drawing.Size(59, 20);
			this.labelAktywnosc.TabIndex = 4;
			this.labelAktywnosc.Text = "Aktywność";
			// 
			// flowLayoutPanelPola
			// 
			this.flowLayoutPanelPola.Controls.Add(this.textBoxLogin);
			this.flowLayoutPanelPola.Controls.Add(this.maskedTextBoxHaslo);
			this.flowLayoutPanelPola.Controls.Add(this.textBoxEmail);
			this.flowLayoutPanelPola.Controls.Add(this.dateTimePickerDataUrodzenia);
			this.flowLayoutPanelPola.Controls.Add(this.checkBoxAktywnosc);
			this.flowLayoutPanelPola.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanelPola.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanelPola.Location = new System.Drawing.Point(103, 3);
			this.flowLayoutPanelPola.Name = "flowLayoutPanelPola";
			this.flowLayoutPanelPola.Size = new System.Drawing.Size(211, 139);
			this.flowLayoutPanelPola.TabIndex = 1;
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.Location = new System.Drawing.Point(3, 3);
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
			this.textBoxLogin.TabIndex = 0;
			// 
			// maskedTextBoxHaslo
			// 
			this.maskedTextBoxHaslo.Location = new System.Drawing.Point(3, 29);
			this.maskedTextBoxHaslo.Name = "maskedTextBoxHaslo";
			this.maskedTextBoxHaslo.PasswordChar = '*';
			this.maskedTextBoxHaslo.Size = new System.Drawing.Size(100, 20);
			this.maskedTextBoxHaslo.TabIndex = 1;
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(3, 55);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
			this.textBoxEmail.TabIndex = 2;
			// 
			// dateTimePickerDataUrodzenia
			// 
			this.dateTimePickerDataUrodzenia.Location = new System.Drawing.Point(3, 81);
			this.dateTimePickerDataUrodzenia.Name = "dateTimePickerDataUrodzenia";
			this.dateTimePickerDataUrodzenia.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerDataUrodzenia.TabIndex = 3;
			// 
			// checkBoxAktywnosc
			// 
			this.checkBoxAktywnosc.AutoSize = true;
			this.checkBoxAktywnosc.Location = new System.Drawing.Point(3, 107);
			this.checkBoxAktywnosc.Name = "checkBoxAktywnosc";
			this.checkBoxAktywnosc.Size = new System.Drawing.Size(85, 17);
			this.checkBoxAktywnosc.TabIndex = 4;
			this.checkBoxAktywnosc.Text = "aktywowany";
			this.checkBoxAktywnosc.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanelOk
			// 
			this.flowLayoutPanelOk.Controls.Add(this.buttonOk);
			this.flowLayoutPanelOk.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanelOk.Location = new System.Drawing.Point(3, 148);
			this.flowLayoutPanelOk.Name = "flowLayoutPanelOk";
			this.flowLayoutPanelOk.Size = new System.Drawing.Size(94, 29);
			this.flowLayoutPanelOk.TabIndex = 2;
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(3, 3);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 0;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// flowLayoutPanelAnuluj
			// 
			this.flowLayoutPanelAnuluj.Controls.Add(this.buttonAnuluj);
			this.flowLayoutPanelAnuluj.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanelAnuluj.Location = new System.Drawing.Point(103, 148);
			this.flowLayoutPanelAnuluj.Name = "flowLayoutPanelAnuluj";
			this.flowLayoutPanelAnuluj.Size = new System.Drawing.Size(211, 29);
			this.flowLayoutPanelAnuluj.TabIndex = 3;
			// 
			// buttonAnuluj
			// 
			this.buttonAnuluj.Location = new System.Drawing.Point(3, 3);
			this.buttonAnuluj.Name = "buttonAnuluj";
			this.buttonAnuluj.Size = new System.Drawing.Size(75, 23);
			this.buttonAnuluj.TabIndex = 0;
			this.buttonAnuluj.Text = "Anuluj";
			this.buttonAnuluj.UseVisualStyleBackColor = true;
			this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
			// 
			// DodajUzytkownikaWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(317, 180);
			this.Controls.Add(this.tableLayoutPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DodajUzytkownikaWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Dodaj użytkownika";
			this.tableLayoutPanel.ResumeLayout(false);
			this.flowLayoutPanelEtykiety.ResumeLayout(false);
			this.flowLayoutPanelEtykiety.PerformLayout();
			this.flowLayoutPanelPola.ResumeLayout(false);
			this.flowLayoutPanelPola.PerformLayout();
			this.flowLayoutPanelOk.ResumeLayout(false);
			this.flowLayoutPanelAnuluj.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEtykiety;
		private System.Windows.Forms.Label labelLogin;
		private System.Windows.Forms.Label labelHaslo;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.Label labelDataUrodzenia;
		private System.Windows.Forms.Label labelAktywnosc;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPola;
		private System.Windows.Forms.TextBox textBoxLogin;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxHaslo;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.DateTimePicker dateTimePickerDataUrodzenia;
		private System.Windows.Forms.CheckBox checkBoxAktywnosc;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOk;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAnuluj;
		private System.Windows.Forms.Button buttonAnuluj;
	}
}