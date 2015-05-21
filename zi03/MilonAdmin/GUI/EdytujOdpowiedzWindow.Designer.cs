using System;

namespace MilonAdmin.GUI {
	partial class EdytujOdpowiedzWindow {
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
			this.flowLayoutPanelPola = new System.Windows.Forms.FlowLayoutPanel();
			this.textBoxOdpowiedz = new System.Windows.Forms.TextBox();
			this.flowLayoutPanelAnuluj = new System.Windows.Forms.FlowLayoutPanel();
			this.buttonAnuluj = new System.Windows.Forms.Button();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanelEtykiety = new System.Windows.Forms.FlowLayoutPanel();
			this.labelPytanie = new System.Windows.Forms.Label();
			this.labelOdpowiedz = new System.Windows.Forms.Label();
			this.flowLayoutPanelOk = new System.Windows.Forms.FlowLayoutPanel();
			this.buttonOk = new System.Windows.Forms.Button();
			this.comboBoxPytanie = new System.Windows.Forms.ComboBox();
			this.flowLayoutPanelPola.SuspendLayout();
			this.flowLayoutPanelAnuluj.SuspendLayout();
			this.tableLayoutPanel.SuspendLayout();
			this.flowLayoutPanelEtykiety.SuspendLayout();
			this.flowLayoutPanelOk.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanelPola
			// 
			this.flowLayoutPanelPola.Controls.Add(this.comboBoxPytanie);
			this.flowLayoutPanelPola.Controls.Add(this.textBoxOdpowiedz);
			this.flowLayoutPanelPola.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanelPola.Location = new System.Drawing.Point(103, 3);
			this.flowLayoutPanelPola.Name = "flowLayoutPanelPola";
			this.flowLayoutPanelPola.Size = new System.Drawing.Size(200, 54);
			this.flowLayoutPanelPola.TabIndex = 1;
			// 
			// textBoxOdpowiedz
			// 
			this.textBoxOdpowiedz.Location = new System.Drawing.Point(3, 30);
			this.textBoxOdpowiedz.Name = "textBoxOdpowiedz";
			this.textBoxOdpowiedz.Size = new System.Drawing.Size(100, 20);
			this.textBoxOdpowiedz.TabIndex = 1;
			// 
			// flowLayoutPanelAnuluj
			// 
			this.flowLayoutPanelAnuluj.Controls.Add(this.buttonAnuluj);
			this.flowLayoutPanelAnuluj.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanelAnuluj.Location = new System.Drawing.Point(103, 63);
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
			this.buttonAnuluj.Text = "Cancel";
			this.buttonAnuluj.UseVisualStyleBackColor = true;
			this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
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
			this.tableLayoutPanel.Size = new System.Drawing.Size(284, 95);
			this.tableLayoutPanel.TabIndex = 2;
			// 
			// flowLayoutPanelEtykiety
			// 
			this.flowLayoutPanelEtykiety.Controls.Add(this.labelPytanie);
			this.flowLayoutPanelEtykiety.Controls.Add(this.labelOdpowiedz);
			this.flowLayoutPanelEtykiety.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanelEtykiety.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanelEtykiety.Name = "flowLayoutPanelEtykiety";
			this.flowLayoutPanelEtykiety.Size = new System.Drawing.Size(94, 54);
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
			// labelOdpowiedz
			// 
			this.labelOdpowiedz.AutoSize = true;
			this.labelOdpowiedz.Location = new System.Drawing.Point(3, 21);
			this.labelOdpowiedz.Name = "labelOdpowiedz";
			this.labelOdpowiedz.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
			this.labelOdpowiedz.Size = new System.Drawing.Size(60, 21);
			this.labelOdpowiedz.TabIndex = 1;
			this.labelOdpowiedz.Text = "Odpowiedz";
			// 
			// flowLayoutPanelOk
			// 
			this.flowLayoutPanelOk.Controls.Add(this.buttonOk);
			this.flowLayoutPanelOk.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanelOk.Location = new System.Drawing.Point(3, 63);
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
			// comboBoxPytanie
			// 
			this.comboBoxPytanie.FormattingEnabled = true;
			this.comboBoxPytanie.Location = new System.Drawing.Point(3, 3);
			this.comboBoxPytanie.Name = "comboBoxPytanie";
			this.comboBoxPytanie.Size = new System.Drawing.Size(121, 21);
			this.comboBoxPytanie.TabIndex = 2;
			// 
			// EdytujOdpowiedzWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 95);
			this.Controls.Add(this.tableLayoutPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EdytujOdpowiedzWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edytuj odpowiedz";
			this.flowLayoutPanelPola.ResumeLayout(false);
			this.flowLayoutPanelPola.PerformLayout();
			this.flowLayoutPanelAnuluj.ResumeLayout(false);
			this.tableLayoutPanel.ResumeLayout(false);
			this.flowLayoutPanelEtykiety.ResumeLayout(false);
			this.flowLayoutPanelEtykiety.PerformLayout();
			this.flowLayoutPanelOk.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPola;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAnuluj;
		private System.Windows.Forms.Button buttonAnuluj;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEtykiety;
		private System.Windows.Forms.Label labelPytanie;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOk;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.TextBox textBoxOdpowiedz;
		private System.Windows.Forms.Label labelOdpowiedz;
		private System.Windows.Forms.ComboBox comboBoxPytanie;
	}
}