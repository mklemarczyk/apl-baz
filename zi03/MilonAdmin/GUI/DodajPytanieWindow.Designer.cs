namespace MilonAdmin.GUI {
	partial class DodajPytanieWindow {
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
			this.labelPytanie = new System.Windows.Forms.Label();
			this.flowLayoutPanelPola = new System.Windows.Forms.FlowLayoutPanel();
			this.textBoxPytanie = new System.Windows.Forms.TextBox();
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
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
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
			this.tableLayoutPanel.Size = new System.Drawing.Size(255, 74);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// flowLayoutPanelEtykiety
			// 
			this.flowLayoutPanelEtykiety.Controls.Add(this.labelPytanie);
			this.flowLayoutPanelEtykiety.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanelEtykiety.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanelEtykiety.Name = "flowLayoutPanelEtykiety";
			this.flowLayoutPanelEtykiety.Size = new System.Drawing.Size(94, 33);
			this.flowLayoutPanelEtykiety.TabIndex = 0;
			// 
			// labelPytanie
			// 
			this.labelPytanie.AutoSize = true;
			this.labelPytanie.Location = new System.Drawing.Point(3, 0);
			this.labelPytanie.Name = "labelPytanie";
			this.labelPytanie.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
			this.labelPytanie.Size = new System.Drawing.Size(42, 21);
			this.labelPytanie.TabIndex = 0;
			this.labelPytanie.Text = "Pytanie";
			// 
			// flowLayoutPanelPola
			// 
			this.flowLayoutPanelPola.Controls.Add(this.textBoxPytanie);
			this.flowLayoutPanelPola.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanelPola.Location = new System.Drawing.Point(103, 3);
			this.flowLayoutPanelPola.Name = "flowLayoutPanelPola";
			this.flowLayoutPanelPola.Size = new System.Drawing.Size(200, 33);
			this.flowLayoutPanelPola.TabIndex = 1;
			// 
			// textBoxPytanie
			// 
			this.textBoxPytanie.Location = new System.Drawing.Point(3, 3);
			this.textBoxPytanie.Name = "textBoxPytanie";
			this.textBoxPytanie.Size = new System.Drawing.Size(100, 20);
			this.textBoxPytanie.TabIndex = 0;
			// 
			// flowLayoutPanelOk
			// 
			this.flowLayoutPanelOk.Controls.Add(this.buttonOk);
			this.flowLayoutPanelOk.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanelOk.Location = new System.Drawing.Point(3, 42);
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
			this.flowLayoutPanelAnuluj.Location = new System.Drawing.Point(103, 42);
			this.flowLayoutPanelAnuluj.Name = "flowLayoutPanelAnuluj";
			this.flowLayoutPanelAnuluj.Size = new System.Drawing.Size(200, 29);
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
			// DodajPytanieWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(255, 74);
			this.Controls.Add(this.tableLayoutPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DodajPytanieWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Dodaj pytanie";
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
		private System.Windows.Forms.Label labelPytanie;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPola;
		private System.Windows.Forms.TextBox textBoxPytanie;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOk;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAnuluj;
		private System.Windows.Forms.Button buttonAnuluj;
	}
}