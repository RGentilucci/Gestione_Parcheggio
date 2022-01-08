namespace Parcheggio
{
    partial class FormUscita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUscita));
        	this.label2 = new System.Windows.Forms.Label();
        	this.lblParcheggio = new System.Windows.Forms.Label();
        	this.txtIngresso = new System.Windows.Forms.TextBox();
        	this.lblIngresso = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.lblOraUscita = new System.Windows.Forms.Label();
        	this.lblMinutiUscita = new System.Windows.Forms.Label();
        	this.txtOraIngresso = new System.Windows.Forms.TextBox();
        	this.txtMinutiIngresso = new System.Windows.Forms.TextBox();
        	this.txtPrezzo = new System.Windows.Forms.TextBox();
        	this.btnConferma = new System.Windows.Forms.Button();
        	this.txtMinutiUscita = new System.Windows.Forms.TextBox();
        	this.txtOraUscita = new System.Windows.Forms.TextBox();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label5 = new System.Windows.Forms.Label();
        	this.btnOK = new System.Windows.Forms.Button();
        	this.label1 = new System.Windows.Forms.Label();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.txtTipoSosta = new System.Windows.Forms.TextBox();
        	this.lblTipoSosta = new System.Windows.Forms.Label();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// label2
        	// 
        	this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
        	this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.ForeColor = System.Drawing.Color.Navy;
        	this.label2.Location = new System.Drawing.Point(12, 49);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(388, 22);
        	this.label2.TabIndex = 13;
        	this.label2.Text = "TICKET USCITA";
        	this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblParcheggio
        	// 
        	this.lblParcheggio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
        	this.lblParcheggio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.lblParcheggio.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblParcheggio.ForeColor = System.Drawing.Color.Navy;
        	this.lblParcheggio.Location = new System.Drawing.Point(12, 9);
        	this.lblParcheggio.Name = "lblParcheggio";
        	this.lblParcheggio.Size = new System.Drawing.Size(388, 36);
        	this.lblParcheggio.TabIndex = 12;
        	this.lblParcheggio.Text = "Park_City";
        	this.lblParcheggio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// txtIngresso
        	// 
        	this.txtIngresso.Location = new System.Drawing.Point(146, 83);
        	this.txtIngresso.Name = "txtIngresso";
        	this.txtIngresso.Size = new System.Drawing.Size(100, 20);
        	this.txtIngresso.TabIndex = 11;
        	// 
        	// lblIngresso
        	// 
        	this.lblIngresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblIngresso.ForeColor = System.Drawing.Color.Navy;
        	this.lblIngresso.Location = new System.Drawing.Point(12, 83);
        	this.lblIngresso.Name = "lblIngresso";
        	this.lblIngresso.Size = new System.Drawing.Size(117, 23);
        	this.lblIngresso.TabIndex = 10;
        	this.lblIngresso.Text = "Targa Autoveicolo";
        	// 
        	// label3
        	// 
        	this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.ForeColor = System.Drawing.Color.Navy;
        	this.label3.Location = new System.Drawing.Point(14, 280);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(80, 23);
        	this.label3.TabIndex = 14;
        	this.label3.Text = "Prezzo (€)";
        	this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// lblOraUscita
        	// 
        	this.lblOraUscita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblOraUscita.ForeColor = System.Drawing.Color.Navy;
        	this.lblOraUscita.Location = new System.Drawing.Point(14, 171);
        	this.lblOraUscita.Name = "lblOraUscita";
        	this.lblOraUscita.Size = new System.Drawing.Size(80, 23);
        	this.lblOraUscita.TabIndex = 15;
        	this.lblOraUscita.Text = "Ora Ingresso";
        	this.lblOraUscita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// lblMinutiUscita
        	// 
        	this.lblMinutiUscita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblMinutiUscita.ForeColor = System.Drawing.Color.Navy;
        	this.lblMinutiUscita.Location = new System.Drawing.Point(14, 199);
        	this.lblMinutiUscita.Name = "lblMinutiUscita";
        	this.lblMinutiUscita.Size = new System.Drawing.Size(103, 23);
        	this.lblMinutiUscita.TabIndex = 16;
        	this.lblMinutiUscita.Text = "Minuti Ingresso";
        	this.lblMinutiUscita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// txtOraIngresso
        	// 
        	this.txtOraIngresso.Location = new System.Drawing.Point(143, 169);
        	this.txtOraIngresso.Name = "txtOraIngresso";
        	this.txtOraIngresso.Size = new System.Drawing.Size(100, 20);
        	this.txtOraIngresso.TabIndex = 17;
        	// 
        	// txtMinutiIngresso
        	// 
        	this.txtMinutiIngresso.Location = new System.Drawing.Point(143, 198);
        	this.txtMinutiIngresso.Name = "txtMinutiIngresso";
        	this.txtMinutiIngresso.Size = new System.Drawing.Size(100, 20);
        	this.txtMinutiIngresso.TabIndex = 18;
        	// 
        	// txtPrezzo
        	// 
        	this.txtPrezzo.Location = new System.Drawing.Point(142, 280);
        	this.txtPrezzo.Name = "txtPrezzo";
        	this.txtPrezzo.Size = new System.Drawing.Size(100, 20);
        	this.txtPrezzo.TabIndex = 19;
        	// 
        	// btnConferma
        	// 
        	this.btnConferma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnConferma.ForeColor = System.Drawing.Color.Navy;
        	this.btnConferma.Location = new System.Drawing.Point(14, 114);
        	this.btnConferma.Name = "btnConferma";
        	this.btnConferma.Size = new System.Drawing.Size(231, 21);
        	this.btnConferma.TabIndex = 20;
        	this.btnConferma.Text = "Conferma";
        	this.btnConferma.UseVisualStyleBackColor = true;
        	this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
        	// 
        	// txtMinutiUscita
        	// 
        	this.txtMinutiUscita.Location = new System.Drawing.Point(142, 253);
        	this.txtMinutiUscita.Name = "txtMinutiUscita";
        	this.txtMinutiUscita.Size = new System.Drawing.Size(100, 20);
        	this.txtMinutiUscita.TabIndex = 26;
        	// 
        	// txtOraUscita
        	// 
        	this.txtOraUscita.Location = new System.Drawing.Point(142, 225);
        	this.txtOraUscita.Name = "txtOraUscita";
        	this.txtOraUscita.Size = new System.Drawing.Size(100, 20);
        	this.txtOraUscita.TabIndex = 25;
        	// 
        	// label4
        	// 
        	this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label4.ForeColor = System.Drawing.Color.Navy;
        	this.label4.Location = new System.Drawing.Point(14, 253);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(103, 23);
        	this.label4.TabIndex = 24;
        	this.label4.Text = "Minuti Uscita";
        	this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// label5
        	// 
        	this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label5.ForeColor = System.Drawing.Color.Navy;
        	this.label5.Location = new System.Drawing.Point(14, 228);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(80, 23);
        	this.label5.TabIndex = 23;
        	this.label5.Text = "Ora Uscita";
        	this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// btnOK
        	// 
        	this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnOK.ForeColor = System.Drawing.Color.Navy;
        	this.btnOK.Location = new System.Drawing.Point(12, 316);
        	this.btnOK.Name = "btnOK";
        	this.btnOK.Size = new System.Drawing.Size(228, 23);
        	this.btnOK.TabIndex = 27;
        	this.btnOK.Text = "OK";
        	this.btnOK.UseVisualStyleBackColor = true;
        	this.btnOK.Click += new System.EventHandler(this.BtnOKClick);
        	// 
        	// label1
        	// 
        	this.label1.BackColor = System.Drawing.Color.Blue;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.ForeColor = System.Drawing.Color.White;
        	this.label1.Location = new System.Drawing.Point(18, 12);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(32, 30);
        	this.label1.TabIndex = 28;
        	this.label1.Text = "P";
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        	this.pictureBox1.Location = new System.Drawing.Point(258, 86);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(142, 136);
        	this.pictureBox1.TabIndex = 29;
        	this.pictureBox1.TabStop = false;
        	// 
        	// txtTipoSosta
        	// 
        	this.txtTipoSosta.Location = new System.Drawing.Point(142, 143);
        	this.txtTipoSosta.Name = "txtTipoSosta";
        	this.txtTipoSosta.Size = new System.Drawing.Size(100, 20);
        	this.txtTipoSosta.TabIndex = 30;
        	// 
        	// lblTipoSosta
        	// 
        	this.lblTipoSosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblTipoSosta.ForeColor = System.Drawing.Color.Navy;
        	this.lblTipoSosta.Location = new System.Drawing.Point(14, 144);
        	this.lblTipoSosta.Name = "lblTipoSosta";
        	this.lblTipoSosta.Size = new System.Drawing.Size(100, 23);
        	this.lblTipoSosta.TabIndex = 31;
        	this.lblTipoSosta.Text = "TipoSosta";
        	this.lblTipoSosta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// FormUscita
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(412, 363);
        	this.Controls.Add(this.lblTipoSosta);
        	this.Controls.Add(this.txtTipoSosta);
        	this.Controls.Add(this.pictureBox1);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.btnOK);
        	this.Controls.Add(this.txtMinutiUscita);
        	this.Controls.Add(this.txtOraUscita);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.label5);
        	this.Controls.Add(this.btnConferma);
        	this.Controls.Add(this.txtPrezzo);
        	this.Controls.Add(this.txtMinutiIngresso);
        	this.Controls.Add(this.txtOraIngresso);
        	this.Controls.Add(this.lblMinutiUscita);
        	this.Controls.Add(this.lblOraUscita);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.lblParcheggio);
        	this.Controls.Add(this.txtIngresso);
        	this.Controls.Add(this.lblIngresso);
        	this.Name = "FormUscita";
        	this.Text = "FormUscita";
        	this.Load += new System.EventHandler(this.FormUscita_Load);
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblParcheggio;
        private System.Windows.Forms.TextBox txtIngresso;
        private System.Windows.Forms.Label lblIngresso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOraUscita;
        private System.Windows.Forms.Label lblMinutiUscita;
        private System.Windows.Forms.TextBox txtOraIngresso;
        private System.Windows.Forms.TextBox txtMinutiIngresso;
        private System.Windows.Forms.TextBox txtPrezzo;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.TextBox txtMinutiUscita;
        private System.Windows.Forms.TextBox txtOraUscita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTipoSosta;
        private System.Windows.Forms.Label lblTipoSosta;
    }
}