namespace MilonAdmin.GUI {
	partial class MainWindow {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.tabControlZakladki = new System.Windows.Forms.TabControl();
			this.tabPageUzytkownicy = new System.Windows.Forms.TabPage();
			this.tableLayoutPanelUzytkownicy = new System.Windows.Forms.TableLayoutPanel();
			this.dataGridViewUzytkownicy = new System.Windows.Forms.DataGridView();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.buttonUzytkownikDodaj = new System.Windows.Forms.Button();
			this.buttonUzytkownikEdytuj = new System.Windows.Forms.Button();
			this.buttonUzytkownikUsun = new System.Windows.Forms.Button();
			this.buttonUzytkownikOdswiez = new System.Windows.Forms.Button();
			this.tabPagePytania = new System.Windows.Forms.TabPage();
			this.tableLayoutPanelPytania = new System.Windows.Forms.TableLayoutPanel();
			this.dataGridViewPytania = new System.Windows.Forms.DataGridView();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.buttonPytanieDodaj = new System.Windows.Forms.Button();
			this.buttonPytanieEdytuj = new System.Windows.Forms.Button();
			this.buttonPytanieUsun = new System.Windows.Forms.Button();
			this.buttonPytanieOdswiez = new System.Windows.Forms.Button();
			this.tabPageOdpowiedzi = new System.Windows.Forms.TabPage();
			this.tableLayoutPanelOdpowiedzi = new System.Windows.Forms.TableLayoutPanel();
			this.dataGridViewOdpowiedzi = new System.Windows.Forms.DataGridView();
			this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
			this.buttonOdpowiedzDodaj = new System.Windows.Forms.Button();
			this.buttonOdpowiedzEdytuj = new System.Windows.Forms.Button();
			this.buttonOdpowiedzUsun = new System.Windows.Forms.Button();
			this.buttonOdpowiedzOdswiez = new System.Windows.Forms.Button();
			this.tabPageUstawienia = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.labelConnectionMode = new System.Windows.Forms.Label();
			this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
			this.checkBoxConnectionMode = new System.Windows.Forms.CheckBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.QuestionId = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.isPlayerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.avatarDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.milionerzyDataSet = new MilonAdmin.MilionerzyDataSet();
			this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.optionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.buttonDodajObrazek = new System.Windows.Forms.Button();
			this.openFileDialogObrazek = new System.Windows.Forms.OpenFileDialog();
			this.tabControlZakladki.SuspendLayout();
			this.tabPageUzytkownicy.SuspendLayout();
			this.tableLayoutPanelUzytkownicy.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUzytkownicy)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.tabPagePytania.SuspendLayout();
			this.tableLayoutPanelPytania.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPytania)).BeginInit();
			this.flowLayoutPanel2.SuspendLayout();
			this.tabPageOdpowiedzi.SuspendLayout();
			this.tableLayoutPanelOdpowiedzi.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdpowiedzi)).BeginInit();
			this.flowLayoutPanel5.SuspendLayout();
			this.tabPageUstawienia.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.flowLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.milionerzyDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.optionBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControlZakladki
			// 
			this.tabControlZakladki.Controls.Add(this.tabPageUzytkownicy);
			this.tabControlZakladki.Controls.Add(this.tabPagePytania);
			this.tabControlZakladki.Controls.Add(this.tabPageOdpowiedzi);
			this.tabControlZakladki.Controls.Add(this.tabPageUstawienia);
			this.tabControlZakladki.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlZakladki.Location = new System.Drawing.Point(0, 0);
			this.tabControlZakladki.Name = "tabControlZakladki";
			this.tabControlZakladki.SelectedIndex = 0;
			this.tabControlZakladki.Size = new System.Drawing.Size(733, 381);
			this.tabControlZakladki.TabIndex = 0;
			// 
			// tabPageUzytkownicy
			// 
			this.tabPageUzytkownicy.Controls.Add(this.tableLayoutPanelUzytkownicy);
			this.tabPageUzytkownicy.Location = new System.Drawing.Point(4, 22);
			this.tabPageUzytkownicy.Name = "tabPageUzytkownicy";
			this.tabPageUzytkownicy.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageUzytkownicy.Size = new System.Drawing.Size(725, 355);
			this.tabPageUzytkownicy.TabIndex = 0;
			this.tabPageUzytkownicy.Text = "Użytkownicy";
			this.tabPageUzytkownicy.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanelUzytkownicy
			// 
			this.tableLayoutPanelUzytkownicy.ColumnCount = 1;
			this.tableLayoutPanelUzytkownicy.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelUzytkownicy.Controls.Add(this.dataGridViewUzytkownicy, 0, 0);
			this.tableLayoutPanelUzytkownicy.Controls.Add(this.flowLayoutPanel1, 0, 1);
			this.tableLayoutPanelUzytkownicy.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelUzytkownicy.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanelUzytkownicy.Name = "tableLayoutPanelUzytkownicy";
			this.tableLayoutPanelUzytkownicy.RowCount = 2;
			this.tableLayoutPanelUzytkownicy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelUzytkownicy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanelUzytkownicy.Size = new System.Drawing.Size(719, 349);
			this.tableLayoutPanelUzytkownicy.TabIndex = 0;
			// 
			// dataGridViewUzytkownicy
			// 
			this.dataGridViewUzytkownicy.AllowUserToAddRows = false;
			this.dataGridViewUzytkownicy.AllowUserToDeleteRows = false;
			this.dataGridViewUzytkownicy.AutoGenerateColumns = false;
			this.dataGridViewUzytkownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewUzytkownicy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.isPlayerDataGridViewCheckBoxColumn,
            this.avatarDataGridViewImageColumn});
			this.dataGridViewUzytkownicy.DataSource = this.userBindingSource;
			this.dataGridViewUzytkownicy.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewUzytkownicy.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewUzytkownicy.Name = "dataGridViewUzytkownicy";
			this.dataGridViewUzytkownicy.ReadOnly = true;
			this.dataGridViewUzytkownicy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewUzytkownicy.Size = new System.Drawing.Size(713, 308);
			this.dataGridViewUzytkownicy.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.buttonUzytkownikDodaj);
			this.flowLayoutPanel1.Controls.Add(this.buttonUzytkownikEdytuj);
			this.flowLayoutPanel1.Controls.Add(this.buttonUzytkownikUsun);
			this.flowLayoutPanel1.Controls.Add(this.buttonUzytkownikOdswiez);
			this.flowLayoutPanel1.Controls.Add(this.buttonDodajObrazek);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 317);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(713, 29);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// buttonUzytkownikDodaj
			// 
			this.buttonUzytkownikDodaj.Location = new System.Drawing.Point(3, 3);
			this.buttonUzytkownikDodaj.Name = "buttonUzytkownikDodaj";
			this.buttonUzytkownikDodaj.Size = new System.Drawing.Size(75, 23);
			this.buttonUzytkownikDodaj.TabIndex = 0;
			this.buttonUzytkownikDodaj.Text = "Dodaj";
			this.buttonUzytkownikDodaj.UseVisualStyleBackColor = true;
			this.buttonUzytkownikDodaj.Click += new System.EventHandler(this.buttonUzytkownikDodaj_Click);
			// 
			// buttonUzytkownikEdytuj
			// 
			this.buttonUzytkownikEdytuj.Location = new System.Drawing.Point(84, 3);
			this.buttonUzytkownikEdytuj.Name = "buttonUzytkownikEdytuj";
			this.buttonUzytkownikEdytuj.Size = new System.Drawing.Size(75, 23);
			this.buttonUzytkownikEdytuj.TabIndex = 1;
			this.buttonUzytkownikEdytuj.Text = "Edytuj";
			this.buttonUzytkownikEdytuj.UseVisualStyleBackColor = true;
			this.buttonUzytkownikEdytuj.Click += new System.EventHandler(this.buttonUzytkownikEdytuj_Click);
			// 
			// buttonUzytkownikUsun
			// 
			this.buttonUzytkownikUsun.Location = new System.Drawing.Point(165, 3);
			this.buttonUzytkownikUsun.Name = "buttonUzytkownikUsun";
			this.buttonUzytkownikUsun.Size = new System.Drawing.Size(75, 23);
			this.buttonUzytkownikUsun.TabIndex = 2;
			this.buttonUzytkownikUsun.Text = "Usuń";
			this.buttonUzytkownikUsun.UseVisualStyleBackColor = true;
			this.buttonUzytkownikUsun.Click += new System.EventHandler(this.buttonUzytkownikUsun_Click);
			// 
			// buttonUzytkownikOdswiez
			// 
			this.buttonUzytkownikOdswiez.Location = new System.Drawing.Point(246, 3);
			this.buttonUzytkownikOdswiez.Name = "buttonUzytkownikOdswiez";
			this.buttonUzytkownikOdswiez.Size = new System.Drawing.Size(75, 23);
			this.buttonUzytkownikOdswiez.TabIndex = 3;
			this.buttonUzytkownikOdswiez.Text = "Odśwież";
			this.buttonUzytkownikOdswiez.UseVisualStyleBackColor = true;
			this.buttonUzytkownikOdswiez.Click += new System.EventHandler(this.buttonUzytkownikOdswiez_Click);
			// 
			// tabPagePytania
			// 
			this.tabPagePytania.Controls.Add(this.tableLayoutPanelPytania);
			this.tabPagePytania.Location = new System.Drawing.Point(4, 22);
			this.tabPagePytania.Name = "tabPagePytania";
			this.tabPagePytania.Padding = new System.Windows.Forms.Padding(3);
			this.tabPagePytania.Size = new System.Drawing.Size(725, 355);
			this.tabPagePytania.TabIndex = 1;
			this.tabPagePytania.Text = "Pytania";
			this.tabPagePytania.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanelPytania
			// 
			this.tableLayoutPanelPytania.ColumnCount = 1;
			this.tableLayoutPanelPytania.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelPytania.Controls.Add(this.dataGridViewPytania, 0, 0);
			this.tableLayoutPanelPytania.Controls.Add(this.flowLayoutPanel2, 0, 1);
			this.tableLayoutPanelPytania.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelPytania.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanelPytania.Name = "tableLayoutPanelPytania";
			this.tableLayoutPanelPytania.RowCount = 2;
			this.tableLayoutPanelPytania.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelPytania.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanelPytania.Size = new System.Drawing.Size(719, 349);
			this.tableLayoutPanelPytania.TabIndex = 0;
			// 
			// dataGridViewPytania
			// 
			this.dataGridViewPytania.AllowUserToAddRows = false;
			this.dataGridViewPytania.AllowUserToDeleteRows = false;
			this.dataGridViewPytania.AutoGenerateColumns = false;
			this.dataGridViewPytania.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewPytania.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contentDataGridViewTextBoxColumn});
			this.dataGridViewPytania.DataSource = this.questionBindingSource;
			this.dataGridViewPytania.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewPytania.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewPytania.Name = "dataGridViewPytania";
			this.dataGridViewPytania.ReadOnly = true;
			this.dataGridViewPytania.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewPytania.Size = new System.Drawing.Size(713, 308);
			this.dataGridViewPytania.TabIndex = 0;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.buttonPytanieDodaj);
			this.flowLayoutPanel2.Controls.Add(this.buttonPytanieEdytuj);
			this.flowLayoutPanel2.Controls.Add(this.buttonPytanieUsun);
			this.flowLayoutPanel2.Controls.Add(this.buttonPytanieOdswiez);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 317);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(713, 29);
			this.flowLayoutPanel2.TabIndex = 1;
			// 
			// buttonPytanieDodaj
			// 
			this.buttonPytanieDodaj.Location = new System.Drawing.Point(3, 3);
			this.buttonPytanieDodaj.Name = "buttonPytanieDodaj";
			this.buttonPytanieDodaj.Size = new System.Drawing.Size(75, 23);
			this.buttonPytanieDodaj.TabIndex = 0;
			this.buttonPytanieDodaj.Text = "Dodaj";
			this.buttonPytanieDodaj.UseVisualStyleBackColor = true;
			this.buttonPytanieDodaj.Click += new System.EventHandler(this.buttonPytanieDodaj_Click);
			// 
			// buttonPytanieEdytuj
			// 
			this.buttonPytanieEdytuj.Location = new System.Drawing.Point(84, 3);
			this.buttonPytanieEdytuj.Name = "buttonPytanieEdytuj";
			this.buttonPytanieEdytuj.Size = new System.Drawing.Size(75, 23);
			this.buttonPytanieEdytuj.TabIndex = 1;
			this.buttonPytanieEdytuj.Text = "Edytuj";
			this.buttonPytanieEdytuj.UseVisualStyleBackColor = true;
			this.buttonPytanieEdytuj.Click += new System.EventHandler(this.buttonPytanieEdytuj_Click);
			// 
			// buttonPytanieUsun
			// 
			this.buttonPytanieUsun.Location = new System.Drawing.Point(165, 3);
			this.buttonPytanieUsun.Name = "buttonPytanieUsun";
			this.buttonPytanieUsun.Size = new System.Drawing.Size(75, 23);
			this.buttonPytanieUsun.TabIndex = 2;
			this.buttonPytanieUsun.Text = "Usuń";
			this.buttonPytanieUsun.UseVisualStyleBackColor = true;
			this.buttonPytanieUsun.Click += new System.EventHandler(this.buttonPytanieUsun_Click);
			// 
			// buttonPytanieOdswiez
			// 
			this.buttonPytanieOdswiez.Location = new System.Drawing.Point(246, 3);
			this.buttonPytanieOdswiez.Name = "buttonPytanieOdswiez";
			this.buttonPytanieOdswiez.Size = new System.Drawing.Size(75, 23);
			this.buttonPytanieOdswiez.TabIndex = 3;
			this.buttonPytanieOdswiez.Text = "Odśwież";
			this.buttonPytanieOdswiez.UseVisualStyleBackColor = true;
			this.buttonPytanieOdswiez.Click += new System.EventHandler(this.buttonPytanieOdswiez_Click);
			// 
			// tabPageOdpowiedzi
			// 
			this.tabPageOdpowiedzi.Controls.Add(this.tableLayoutPanelOdpowiedzi);
			this.tabPageOdpowiedzi.Location = new System.Drawing.Point(4, 22);
			this.tabPageOdpowiedzi.Name = "tabPageOdpowiedzi";
			this.tabPageOdpowiedzi.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageOdpowiedzi.Size = new System.Drawing.Size(725, 355);
			this.tabPageOdpowiedzi.TabIndex = 3;
			this.tabPageOdpowiedzi.Text = "Odpowiedzi";
			this.tabPageOdpowiedzi.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanelOdpowiedzi
			// 
			this.tableLayoutPanelOdpowiedzi.ColumnCount = 1;
			this.tableLayoutPanelOdpowiedzi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelOdpowiedzi.Controls.Add(this.dataGridViewOdpowiedzi, 0, 0);
			this.tableLayoutPanelOdpowiedzi.Controls.Add(this.flowLayoutPanel5, 0, 1);
			this.tableLayoutPanelOdpowiedzi.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelOdpowiedzi.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanelOdpowiedzi.Name = "tableLayoutPanelOdpowiedzi";
			this.tableLayoutPanelOdpowiedzi.RowCount = 2;
			this.tableLayoutPanelOdpowiedzi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelOdpowiedzi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanelOdpowiedzi.Size = new System.Drawing.Size(719, 349);
			this.tableLayoutPanelOdpowiedzi.TabIndex = 0;
			// 
			// dataGridViewOdpowiedzi
			// 
			this.dataGridViewOdpowiedzi.AllowUserToAddRows = false;
			this.dataGridViewOdpowiedzi.AllowUserToDeleteRows = false;
			this.dataGridViewOdpowiedzi.AutoGenerateColumns = false;
			this.dataGridViewOdpowiedzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOdpowiedzi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuestionId,
            this.dataGridViewTextBoxColumn1});
			this.dataGridViewOdpowiedzi.DataSource = this.optionBindingSource;
			this.dataGridViewOdpowiedzi.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewOdpowiedzi.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewOdpowiedzi.Name = "dataGridViewOdpowiedzi";
			this.dataGridViewOdpowiedzi.ReadOnly = true;
			this.dataGridViewOdpowiedzi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewOdpowiedzi.Size = new System.Drawing.Size(713, 308);
			this.dataGridViewOdpowiedzi.TabIndex = 0;
			// 
			// flowLayoutPanel5
			// 
			this.flowLayoutPanel5.Controls.Add(this.buttonOdpowiedzDodaj);
			this.flowLayoutPanel5.Controls.Add(this.buttonOdpowiedzEdytuj);
			this.flowLayoutPanel5.Controls.Add(this.buttonOdpowiedzUsun);
			this.flowLayoutPanel5.Controls.Add(this.buttonOdpowiedzOdswiez);
			this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 317);
			this.flowLayoutPanel5.Name = "flowLayoutPanel5";
			this.flowLayoutPanel5.Size = new System.Drawing.Size(713, 29);
			this.flowLayoutPanel5.TabIndex = 1;
			// 
			// buttonOdpowiedzDodaj
			// 
			this.buttonOdpowiedzDodaj.Location = new System.Drawing.Point(3, 3);
			this.buttonOdpowiedzDodaj.Name = "buttonOdpowiedzDodaj";
			this.buttonOdpowiedzDodaj.Size = new System.Drawing.Size(75, 23);
			this.buttonOdpowiedzDodaj.TabIndex = 0;
			this.buttonOdpowiedzDodaj.Text = "Dodaj";
			this.buttonOdpowiedzDodaj.UseVisualStyleBackColor = true;
			this.buttonOdpowiedzDodaj.Click += new System.EventHandler(this.buttonOdpowiedzDodaj_Click);
			// 
			// buttonOdpowiedzEdytuj
			// 
			this.buttonOdpowiedzEdytuj.Location = new System.Drawing.Point(84, 3);
			this.buttonOdpowiedzEdytuj.Name = "buttonOdpowiedzEdytuj";
			this.buttonOdpowiedzEdytuj.Size = new System.Drawing.Size(75, 23);
			this.buttonOdpowiedzEdytuj.TabIndex = 1;
			this.buttonOdpowiedzEdytuj.Text = "Edytuj";
			this.buttonOdpowiedzEdytuj.UseVisualStyleBackColor = true;
			this.buttonOdpowiedzEdytuj.Click += new System.EventHandler(this.buttonOdpowiedzEdytuj_Click);
			// 
			// buttonOdpowiedzUsun
			// 
			this.buttonOdpowiedzUsun.Location = new System.Drawing.Point(165, 3);
			this.buttonOdpowiedzUsun.Name = "buttonOdpowiedzUsun";
			this.buttonOdpowiedzUsun.Size = new System.Drawing.Size(75, 23);
			this.buttonOdpowiedzUsun.TabIndex = 2;
			this.buttonOdpowiedzUsun.Text = "Usuń";
			this.buttonOdpowiedzUsun.UseVisualStyleBackColor = true;
			this.buttonOdpowiedzUsun.Click += new System.EventHandler(this.buttonOdpowiedzUsun_Click);
			// 
			// buttonOdpowiedzOdswiez
			// 
			this.buttonOdpowiedzOdswiez.Location = new System.Drawing.Point(246, 3);
			this.buttonOdpowiedzOdswiez.Name = "buttonOdpowiedzOdswiez";
			this.buttonOdpowiedzOdswiez.Size = new System.Drawing.Size(75, 23);
			this.buttonOdpowiedzOdswiez.TabIndex = 3;
			this.buttonOdpowiedzOdswiez.Text = "Odśwież";
			this.buttonOdpowiedzOdswiez.UseVisualStyleBackColor = true;
			this.buttonOdpowiedzOdswiez.Click += new System.EventHandler(this.buttonOdpowiedzOdswiez_Click);
			// 
			// tabPageUstawienia
			// 
			this.tabPageUstawienia.Controls.Add(this.tableLayoutPanel1);
			this.tabPageUstawienia.Location = new System.Drawing.Point(4, 22);
			this.tabPageUstawienia.Name = "tabPageUstawienia";
			this.tabPageUstawienia.Size = new System.Drawing.Size(725, 355);
			this.tabPageUstawienia.TabIndex = 2;
			this.tabPageUstawienia.Text = "Ustawienia";
			this.tabPageUstawienia.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 545F));
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.buttonSave, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(725, 355);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this.labelConnectionMode);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(144, 314);
			this.flowLayoutPanel3.TabIndex = 0;
			// 
			// labelConnectionMode
			// 
			this.labelConnectionMode.AutoSize = true;
			this.labelConnectionMode.Location = new System.Drawing.Point(3, 0);
			this.labelConnectionMode.Name = "labelConnectionMode";
			this.labelConnectionMode.Padding = new System.Windows.Forms.Padding(0, 4, 0, 3);
			this.labelConnectionMode.Size = new System.Drawing.Size(84, 20);
			this.labelConnectionMode.TabIndex = 0;
			this.labelConnectionMode.Text = "Tryb połączenia";
			// 
			// flowLayoutPanel4
			// 
			this.flowLayoutPanel4.Controls.Add(this.checkBoxConnectionMode);
			this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel4.Location = new System.Drawing.Point(153, 3);
			this.flowLayoutPanel4.Name = "flowLayoutPanel4";
			this.flowLayoutPanel4.Size = new System.Drawing.Size(144, 314);
			this.flowLayoutPanel4.TabIndex = 1;
			// 
			// checkBoxConnectionMode
			// 
			this.checkBoxConnectionMode.AutoSize = true;
			this.checkBoxConnectionMode.Location = new System.Drawing.Point(3, 3);
			this.checkBoxConnectionMode.Name = "checkBoxConnectionMode";
			this.checkBoxConnectionMode.Size = new System.Drawing.Size(122, 17);
			this.checkBoxConnectionMode.TabIndex = 0;
			this.checkBoxConnectionMode.Text = "Utrzymuj połączenie";
			this.checkBoxConnectionMode.UseVisualStyleBackColor = true;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(153, 323);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 2;
			this.buttonSave.Text = "Zapisz";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// QuestionId
			// 
			this.QuestionId.DataPropertyName = "QuestionId";
			this.QuestionId.DataSource = this.questionBindingSource;
			this.QuestionId.DisplayMember = "Content";
			this.QuestionId.HeaderText = "Pytanie";
			this.QuestionId.Name = "QuestionId";
			this.QuestionId.ReadOnly = true;
			this.QuestionId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.QuestionId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.QuestionId.ValueMember = "Id";
			// 
			// loginDataGridViewTextBoxColumn
			// 
			this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
			this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
			this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
			this.loginDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			this.emailDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// birthdateDataGridViewTextBoxColumn
			// 
			this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "Birthdate";
			this.birthdateDataGridViewTextBoxColumn.HeaderText = "Data urodzenia";
			this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
			this.birthdateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// isPlayerDataGridViewCheckBoxColumn
			// 
			this.isPlayerDataGridViewCheckBoxColumn.DataPropertyName = "IsPlayer";
			this.isPlayerDataGridViewCheckBoxColumn.HeaderText = "Aktywność";
			this.isPlayerDataGridViewCheckBoxColumn.Name = "isPlayerDataGridViewCheckBoxColumn";
			this.isPlayerDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// avatarDataGridViewImageColumn
			// 
			this.avatarDataGridViewImageColumn.DataPropertyName = "Avatar";
			this.avatarDataGridViewImageColumn.HeaderText = "Avatar";
			this.avatarDataGridViewImageColumn.Name = "avatarDataGridViewImageColumn";
			this.avatarDataGridViewImageColumn.ReadOnly = true;
			// 
			// userBindingSource
			// 
			this.userBindingSource.DataMember = "Users";
			this.userBindingSource.DataSource = this.milionerzyDataSet;
			// 
			// milionerzyDataSet
			// 
			this.milionerzyDataSet.DataSetName = "MilionerzyDataSet";
			this.milionerzyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// contentDataGridViewTextBoxColumn
			// 
			this.contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
			this.contentDataGridViewTextBoxColumn.HeaderText = "Pytanie";
			this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
			this.contentDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// questionBindingSource
			// 
			this.questionBindingSource.DataMember = "Questions";
			this.questionBindingSource.DataSource = this.milionerzyDataSet;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Content";
			this.dataGridViewTextBoxColumn1.HeaderText = "Odpowiedz";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// optionBindingSource
			// 
			this.optionBindingSource.DataMember = "Options";
			this.optionBindingSource.DataSource = this.milionerzyDataSet;
			// 
			// buttonDodajObrazek
			// 
			this.buttonDodajObrazek.Location = new System.Drawing.Point(327, 3);
			this.buttonDodajObrazek.Name = "buttonDodajObrazek";
			this.buttonDodajObrazek.Size = new System.Drawing.Size(100, 23);
			this.buttonDodajObrazek.TabIndex = 4;
			this.buttonDodajObrazek.Text = "Dodaj obrazek";
			this.buttonDodajObrazek.UseVisualStyleBackColor = true;
			this.buttonDodajObrazek.Click += new System.EventHandler(this.buttonDodajObrazek_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(733, 381);
			this.Controls.Add(this.tabControlZakladki);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainWindow";
			this.Text = "Milion Admin";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.tabControlZakladki.ResumeLayout(false);
			this.tabPageUzytkownicy.ResumeLayout(false);
			this.tableLayoutPanelUzytkownicy.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUzytkownicy)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.tabPagePytania.ResumeLayout(false);
			this.tableLayoutPanelPytania.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPytania)).EndInit();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.tabPageOdpowiedzi.ResumeLayout(false);
			this.tableLayoutPanelOdpowiedzi.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdpowiedzi)).EndInit();
			this.flowLayoutPanel5.ResumeLayout(false);
			this.tabPageUstawienia.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			this.flowLayoutPanel4.ResumeLayout(false);
			this.flowLayoutPanel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.milionerzyDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.optionBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControlZakladki;
		private System.Windows.Forms.TabPage tabPageUzytkownicy;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUzytkownicy;
		private System.Windows.Forms.DataGridView dataGridViewUzytkownicy;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button buttonUzytkownikDodaj;
		private System.Windows.Forms.Button buttonUzytkownikEdytuj;
		private System.Windows.Forms.Button buttonUzytkownikUsun;
		private System.Windows.Forms.TabPage tabPagePytania;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPytania;
		private System.Windows.Forms.DataGridView dataGridViewPytania;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Button buttonPytanieDodaj;
		private System.Windows.Forms.Button buttonPytanieEdytuj;
		private System.Windows.Forms.Button buttonPytanieUsun;
		private System.Windows.Forms.Button buttonUzytkownikOdswiez;
		private System.Windows.Forms.Button buttonPytanieOdswiez;
		private MilionerzyDataSet milionerzyDataSet;
		private System.Windows.Forms.BindingSource userBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isPlayerDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewImageColumn avatarDataGridViewImageColumn;
		private System.Windows.Forms.BindingSource questionBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
		private System.Windows.Forms.TabPage tabPageUstawienia;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.Label labelConnectionMode;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
		private System.Windows.Forms.CheckBox checkBoxConnectionMode;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.TabPage tabPageOdpowiedzi;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOdpowiedzi;
		private System.Windows.Forms.DataGridView dataGridViewOdpowiedzi;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
		private System.Windows.Forms.Button buttonOdpowiedzDodaj;
		private System.Windows.Forms.Button buttonOdpowiedzEdytuj;
		private System.Windows.Forms.Button buttonOdpowiedzUsun;
		private System.Windows.Forms.Button buttonOdpowiedzOdswiez;
		private System.Windows.Forms.BindingSource optionBindingSource;
		private System.Windows.Forms.DataGridViewComboBoxColumn QuestionId;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.Button buttonDodajObrazek;
		private System.Windows.Forms.OpenFileDialog openFileDialogObrazek;
	}
}