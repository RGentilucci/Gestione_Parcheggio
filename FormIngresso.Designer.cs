/*
 * Created by SharpDevelop.
 * User: UID0803510
 * Date: 13/12/2021
 * Time: 17:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Parcheggio
{
	partial class FormIngresso
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label Data;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtData;
		private System.Windows.Forms.TextBox txtOra;
		private System.Windows.Forms.TextBox txtMinuti;
		private System.Windows.Forms.PictureBox pct1;
		private System.Windows.Forms.Label lblTarga;
		private System.Windows.Forms.Label lblTipo;
		private System.Windows.Forms.TextBox txtTarga;
		private System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.Button btnConferma;
		private System.Windows.Forms.Label lblParcheggio;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblAlimentazione;
		private System.Windows.Forms.ComboBox cmbTipoMotore;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngresso));
			this.Data = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtData = new System.Windows.Forms.TextBox();
			this.txtOra = new System.Windows.Forms.TextBox();
			this.txtMinuti = new System.Windows.Forms.TextBox();
			this.pct1 = new System.Windows.Forms.PictureBox();
			this.lblTarga = new System.Windows.Forms.Label();
			this.lblTipo = new System.Windows.Forms.Label();
			this.txtTarga = new System.Windows.Forms.TextBox();
			this.cmbTipo = new System.Windows.Forms.ComboBox();
			this.btnConferma = new System.Windows.Forms.Button();
			this.lblParcheggio = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblAlimentazione = new System.Windows.Forms.Label();
			this.cmbTipoMotore = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pct1)).BeginInit();
			this.SuspendLayout();
			// 
			// Data
			// 
			this.Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Data.ForeColor = System.Drawing.Color.Navy;
			this.Data.Location = new System.Drawing.Point(27, 78);
			this.Data.Name = "Data";
			this.Data.Size = new System.Drawing.Size(100, 20);
			this.Data.TabIndex = 2;
			this.Data.Text = "Data";
			this.Data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Location = new System.Drawing.Point(27, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Ora";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Navy;
			this.label3.Location = new System.Drawing.Point(27, 131);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Minuti";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtData
			// 
			this.txtData.Location = new System.Drawing.Point(133, 79);
			this.txtData.Name = "txtData";
			this.txtData.Size = new System.Drawing.Size(121, 20);
			this.txtData.TabIndex = 5;
			// 
			// txtOra
			// 
			this.txtOra.Location = new System.Drawing.Point(133, 105);
			this.txtOra.Name = "txtOra";
			this.txtOra.Size = new System.Drawing.Size(121, 20);
			this.txtOra.TabIndex = 6;
			// 
			// txtMinuti
			// 
			this.txtMinuti.Location = new System.Drawing.Point(133, 131);
			this.txtMinuti.Name = "txtMinuti";
			this.txtMinuti.Size = new System.Drawing.Size(121, 20);
			this.txtMinuti.TabIndex = 7;
			// 
			// pct1
			// 
			this.pct1.Image = ((System.Drawing.Image)(resources.GetObject("pct1.Image")));
			this.pct1.Location = new System.Drawing.Point(270, 79);
			this.pct1.Name = "pct1";
			this.pct1.Size = new System.Drawing.Size(118, 123);
			this.pct1.TabIndex = 8;
			this.pct1.TabStop = false;
			// 
			// lblTarga
			// 
			this.lblTarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTarga.ForeColor = System.Drawing.Color.Navy;
			this.lblTarga.Location = new System.Drawing.Point(27, 159);
			this.lblTarga.Name = "lblTarga";
			this.lblTarga.Size = new System.Drawing.Size(100, 23);
			this.lblTarga.TabIndex = 9;
			this.lblTarga.Text = "Targa";
			this.lblTarga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTipo
			// 
			this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTipo.ForeColor = System.Drawing.Color.Navy;
			this.lblTipo.Location = new System.Drawing.Point(27, 184);
			this.lblTipo.Name = "lblTipo";
			this.lblTipo.Size = new System.Drawing.Size(100, 23);
			this.lblTipo.TabIndex = 10;
			this.lblTipo.Text = "Tipo Automezzo";
			this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtTarga
			// 
			this.txtTarga.Location = new System.Drawing.Point(133, 159);
			this.txtTarga.Name = "txtTarga";
			this.txtTarga.Size = new System.Drawing.Size(122, 20);
			this.txtTarga.TabIndex = 11;
			// 
			// cmbTipo
			// 
			this.cmbTipo.FormattingEnabled = true;
			this.cmbTipo.Items.AddRange(new object[] {
			"Automobile",
			"Motocicletta",
			"Camper"});
			this.cmbTipo.Location = new System.Drawing.Point(133, 185);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(121, 21);
			this.cmbTipo.TabIndex = 12;
			// 
			// btnConferma
			// 
			this.btnConferma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConferma.ForeColor = System.Drawing.Color.Navy;
			this.btnConferma.Location = new System.Drawing.Point(136, 250);
			this.btnConferma.Name = "btnConferma";
			this.btnConferma.Size = new System.Drawing.Size(118, 23);
			this.btnConferma.TabIndex = 15;
			this.btnConferma.Text = "Conferma";
			this.btnConferma.UseVisualStyleBackColor = true;
			this.btnConferma.Click += new System.EventHandler(this.BtnConfermaClick);
			// 
			// lblParcheggio
			// 
			this.lblParcheggio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblParcheggio.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblParcheggio.ForeColor = System.Drawing.Color.Navy;
			this.lblParcheggio.Location = new System.Drawing.Point(13, 9);
			this.lblParcheggio.Name = "lblParcheggio";
			this.lblParcheggio.Size = new System.Drawing.Size(395, 33);
			this.lblParcheggio.TabIndex = 16;
			this.lblParcheggio.Text = "Park_City";
			this.lblParcheggio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Blue;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(27, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 30);
			this.label4.TabIndex = 17;
			this.label4.Text = "P";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Navy;
			this.label5.Location = new System.Drawing.Point(27, 46);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(381, 21);
			this.label5.TabIndex = 18;
			this.label5.Text = "TICKET INGRESSO";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblAlimentazione
			// 
			this.lblAlimentazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAlimentazione.ForeColor = System.Drawing.Color.Navy;
			this.lblAlimentazione.Location = new System.Drawing.Point(26, 211);
			this.lblAlimentazione.Name = "lblAlimentazione";
			this.lblAlimentazione.Size = new System.Drawing.Size(102, 23);
			this.lblAlimentazione.TabIndex = 21;
			this.lblAlimentazione.Text = "Tipo Motore";
			this.lblAlimentazione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmbTipoMotore
			// 
			this.cmbTipoMotore.FormattingEnabled = true;
			this.cmbTipoMotore.Items.AddRange(new object[] {
			"Benzina",
			"Gasolio",
			"Elettrico",
			"Ibrido"});
			this.cmbTipoMotore.Location = new System.Drawing.Point(133, 212);
			this.cmbTipoMotore.Name = "cmbTipoMotore";
			this.cmbTipoMotore.Size = new System.Drawing.Size(121, 21);
			this.cmbTipoMotore.TabIndex = 22;
			// 
			// FormIngresso
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(420, 285);
			this.Controls.Add(this.cmbTipoMotore);
			this.Controls.Add(this.lblAlimentazione);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblParcheggio);
			this.Controls.Add(this.btnConferma);
			this.Controls.Add(this.cmbTipo);
			this.Controls.Add(this.txtTarga);
			this.Controls.Add(this.lblTipo);
			this.Controls.Add(this.lblTarga);
			this.Controls.Add(this.pct1);
			this.Controls.Add(this.txtMinuti);
			this.Controls.Add(this.txtOra);
			this.Controls.Add(this.txtData);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Data);
			this.ForeColor = System.Drawing.Color.Black;
			this.Name = "FormIngresso";
			this.Text = "FormIngresso";
			this.Load += new System.EventHandler(this.FormIngresso_Load);
			((System.ComponentModel.ISupportInitialize)(this.pct1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
