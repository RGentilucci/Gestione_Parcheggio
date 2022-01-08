/*
 * Created by SharpDevelop.
 * User: UID0803510
 * Date: 28/12/2021
 * Time: 19:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Parcheggio
{
	partial class FormGestione
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnModificaParametri;
		private System.Windows.Forms.Button btnElaborazioneDati;
		private System.Windows.Forms.Button btnModificaPassword;
		private System.Windows.Forms.Button btnAnnulla;
		private System.Windows.Forms.Label lblPark;
		private System.Windows.Forms.Label lblP;
		private System.Windows.Forms.Label lblGestione;
		
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
			this.btnModificaParametri = new System.Windows.Forms.Button();
			this.btnElaborazioneDati = new System.Windows.Forms.Button();
			this.btnModificaPassword = new System.Windows.Forms.Button();
			this.btnAnnulla = new System.Windows.Forms.Button();
			this.lblPark = new System.Windows.Forms.Label();
			this.lblP = new System.Windows.Forms.Label();
			this.lblGestione = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnModificaParametri
			// 
			this.btnModificaParametri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificaParametri.ForeColor = System.Drawing.Color.Navy;
			this.btnModificaParametri.Location = new System.Drawing.Point(48, 101);
			this.btnModificaParametri.Name = "btnModificaParametri";
			this.btnModificaParametri.Size = new System.Drawing.Size(191, 23);
			this.btnModificaParametri.TabIndex = 0;
			this.btnModificaParametri.Text = "Modifica Parametri Parcheggio";
			this.btnModificaParametri.UseVisualStyleBackColor = true;
			this.btnModificaParametri.Click += new System.EventHandler(this.BtnModificaParametriClick);
			// 
			// btnElaborazioneDati
			// 
			this.btnElaborazioneDati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnElaborazioneDati.ForeColor = System.Drawing.Color.Navy;
			this.btnElaborazioneDati.Location = new System.Drawing.Point(48, 136);
			this.btnElaborazioneDati.Name = "btnElaborazioneDati";
			this.btnElaborazioneDati.Size = new System.Drawing.Size(191, 23);
			this.btnElaborazioneDati.TabIndex = 1;
			this.btnElaborazioneDati.Text = "Elaborazione Dati Parcheggio";
			this.btnElaborazioneDati.UseVisualStyleBackColor = true;
			this.btnElaborazioneDati.Click += new System.EventHandler(this.BtnElaborazioneDatiClick);
			// 
			// btnModificaPassword
			// 
			this.btnModificaPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificaPassword.ForeColor = System.Drawing.Color.Navy;
			this.btnModificaPassword.Location = new System.Drawing.Point(48, 174);
			this.btnModificaPassword.Name = "btnModificaPassword";
			this.btnModificaPassword.Size = new System.Drawing.Size(191, 23);
			this.btnModificaPassword.TabIndex = 2;
			this.btnModificaPassword.Text = "Modifica Password Sistema";
			this.btnModificaPassword.UseVisualStyleBackColor = true;
			this.btnModificaPassword.Click += new System.EventHandler(this.BtnModificaPasswordClick);
			// 
			// btnAnnulla
			// 
			this.btnAnnulla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAnnulla.ForeColor = System.Drawing.Color.Navy;
			this.btnAnnulla.Location = new System.Drawing.Point(101, 216);
			this.btnAnnulla.Name = "btnAnnulla";
			this.btnAnnulla.Size = new System.Drawing.Size(75, 23);
			this.btnAnnulla.TabIndex = 3;
			this.btnAnnulla.Text = "Annulla";
			this.btnAnnulla.UseVisualStyleBackColor = true;
			this.btnAnnulla.Click += new System.EventHandler(this.BtnAnnullaClick);
			// 
			// lblPark
			// 
			this.lblPark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPark.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPark.ForeColor = System.Drawing.Color.Navy;
			this.lblPark.Location = new System.Drawing.Point(13, 13);
			this.lblPark.Name = "lblPark";
			this.lblPark.Size = new System.Drawing.Size(260, 35);
			this.lblPark.TabIndex = 4;
			this.lblPark.Text = "Park_City";
			this.lblPark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblP
			// 
			this.lblP.BackColor = System.Drawing.Color.Blue;
			this.lblP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblP.ForeColor = System.Drawing.Color.White;
			this.lblP.Location = new System.Drawing.Point(16, 16);
			this.lblP.Name = "lblP";
			this.lblP.Size = new System.Drawing.Size(30, 30);
			this.lblP.TabIndex = 5;
			this.lblP.Text = "P";
			// 
			// lblGestione
			// 
			this.lblGestione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.lblGestione.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblGestione.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGestione.ForeColor = System.Drawing.Color.Navy;
			this.lblGestione.Location = new System.Drawing.Point(16, 52);
			this.lblGestione.Name = "lblGestione";
			this.lblGestione.Size = new System.Drawing.Size(256, 23);
			this.lblGestione.TabIndex = 6;
			this.lblGestione.Text = "GESTIONE PARCHEGGIO";
			this.lblGestione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormGestione
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 248);
			this.Controls.Add(this.lblGestione);
			this.Controls.Add(this.lblP);
			this.Controls.Add(this.lblPark);
			this.Controls.Add(this.btnAnnulla);
			this.Controls.Add(this.btnModificaPassword);
			this.Controls.Add(this.btnElaborazioneDati);
			this.Controls.Add(this.btnModificaParametri);
			this.Name = "FormGestione";
			this.Text = "FormGestione";
			this.ResumeLayout(false);

		}
	}
}
