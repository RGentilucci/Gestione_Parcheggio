/*
 * Created by SharpDevelop.
 * User: UID0803510
 * Date: 28/12/2021
 * Time: 18:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Parcheggio
{
	partial class FormProxyPassword
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label lblPark;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblP;
		
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
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.lblPark = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblP = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(73, 138);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(127, 20);
			this.txtPassword.TabIndex = 0;
			// 
			// lblPassword
			// 
			this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.ForeColor = System.Drawing.Color.Navy;
			this.lblPassword.Location = new System.Drawing.Point(46, 101);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(189, 34);
			this.lblPassword.TabIndex = 1;
			this.lblPassword.Text = "Inserisci Password \r\n(max. 10 caratteri)";
			this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnOK
			// 
			this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOK.ForeColor = System.Drawing.Color.Navy;
			this.btnOK.Location = new System.Drawing.Point(97, 174);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.BtnOKClick);
			// 
			// lblPark
			// 
			this.lblPark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPark.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPark.ForeColor = System.Drawing.Color.Navy;
			this.lblPark.Location = new System.Drawing.Point(13, 13);
			this.lblPark.Name = "lblPark";
			this.lblPark.Size = new System.Drawing.Size(260, 35);
			this.lblPark.TabIndex = 3;
			this.lblPark.Text = "Park_City";
			this.lblPark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(13, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(259, 19);
			this.label1.TabIndex = 4;
			this.label1.Text = "MODULO ACCOUNT";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblP
			// 
			this.lblP.BackColor = System.Drawing.Color.Blue;
			this.lblP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblP.ForeColor = System.Drawing.Color.White;
			this.lblP.Location = new System.Drawing.Point(17, 16);
			this.lblP.Name = "lblP";
			this.lblP.Size = new System.Drawing.Size(30, 30);
			this.lblP.TabIndex = 5;
			this.lblP.Text = "P";
			this.lblP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormProxyPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 241);
			this.Controls.Add(this.lblP);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblPark);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.txtPassword);
			this.Name = "FormProxyPassword";
			this.Text = "FormProxyPassword";
			this.Load += new System.EventHandler(this.FormProxyPasswordLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
