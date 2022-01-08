/*
 * Created by SharpDevelop.
 * User: UID0803510
 * Date: 23/12/2021
 * Time: 18:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Parcheggio
{
	partial class FormPassword
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtNuovaPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Button btnPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		
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
			this.txtNuovaPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.btnPassword = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtNuovaPassword
			// 
			this.txtNuovaPassword.Location = new System.Drawing.Point(77, 143);
			this.txtNuovaPassword.Name = "txtNuovaPassword";
			this.txtNuovaPassword.Size = new System.Drawing.Size(123, 20);
			this.txtNuovaPassword.TabIndex = 0;
			// 
			// lblPassword
			// 
			this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.ForeColor = System.Drawing.Color.Navy;
			this.lblPassword.Location = new System.Drawing.Point(68, 101);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(156, 34);
			this.lblPassword.TabIndex = 1;
			this.lblPassword.Text = "Inserisci Nuova Password (max. 10 caratteri)";
			this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnPassword
			// 
			this.btnPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPassword.ForeColor = System.Drawing.Color.Navy;
			this.btnPassword.Location = new System.Drawing.Point(101, 169);
			this.btnPassword.Name = "btnPassword";
			this.btnPassword.Size = new System.Drawing.Size(71, 23);
			this.btnPassword.TabIndex = 2;
			this.btnPassword.Text = "OK";
			this.btnPassword.UseVisualStyleBackColor = true;
			this.btnPassword.Click += new System.EventHandler(this.BtnPasswordClick);
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(260, 37);
			this.label1.TabIndex = 3;
			this.label1.Text = "Park_City";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Blue;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(18, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 30);
			this.label2.TabIndex = 4;
			this.label2.Text = "P";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Navy;
			this.label3.Location = new System.Drawing.Point(12, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(260, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "MODIFICA PASSWORD";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 241);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnPassword);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.txtNuovaPassword);
			this.Name = "FormPassword";
			this.Text = "FormPassword";
			this.Load += new System.EventHandler(this.FormPassword_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
