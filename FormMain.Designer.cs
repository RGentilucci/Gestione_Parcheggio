namespace Parcheggio
{
    partial class FormMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
        	this.lblTitolo = new System.Windows.Forms.Label();
        	this.lblPostiTotali = new System.Windows.Forms.Label();
        	this.lbl_costo = new System.Windows.Forms.Label();
        	this.txt_posti_totali = new System.Windows.Forms.TextBox();
        	this.txt_costo = new System.Windows.Forms.TextBox();
        	this.group_box1 = new System.Windows.Forms.GroupBox();
        	this.txt_posti_disponibili = new System.Windows.Forms.TextBox();
        	this.txt_posti_occupati = new System.Windows.Forms.TextBox();
        	this.lblPostiDisponibili = new System.Windows.Forms.Label();
        	this.lblPostiOccupati = new System.Windows.Forms.Label();
        	this.btnIngresso = new System.Windows.Forms.Button();
        	this.btn_Uscita = new System.Windows.Forms.Button();
        	this.label2 = new System.Windows.Forms.Label();
        	this.lbl_Disponibilità = new System.Windows.Forms.Label();
        	this.lbl_Ingresso = new System.Windows.Forms.Label();
        	this.group_box2 = new System.Windows.Forms.GroupBox();
        	this.txt_durata_sosta_oraria = new System.Windows.Forms.TextBox();
        	this.lblDurataSostaOraria = new System.Windows.Forms.Label();
        	this.txt_costo_giornaliero = new System.Windows.Forms.TextBox();
        	this.lblCostoGiornaliero = new System.Windows.Forms.Label();
        	this.txt_data = new System.Windows.Forms.TextBox();
        	this.lstServizi = new System.Windows.Forms.ListBox();
        	this.lblServizi = new System.Windows.Forms.Label();
        	this.lblSemaforo = new System.Windows.Forms.Label();
        	this.txtDisponibilità = new System.Windows.Forms.TextBox();
        	this.btnGestioneParcheggio = new System.Windows.Forms.Button();
        	this.lblInfo = new System.Windows.Forms.Label();
        	this.lblP2 = new System.Windows.Forms.Label();
        	this.group_box1.SuspendLayout();
        	this.group_box2.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// lblTitolo
        	// 
        	this.lblTitolo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
        	this.lblTitolo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.lblTitolo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblTitolo.ForeColor = System.Drawing.Color.Navy;
        	this.lblTitolo.Location = new System.Drawing.Point(12, 9);
        	this.lblTitolo.Name = "lblTitolo";
        	this.lblTitolo.RightToLeft = System.Windows.Forms.RightToLeft.No;
        	this.lblTitolo.Size = new System.Drawing.Size(463, 47);
        	this.lblTitolo.TabIndex = 0;
        	this.lblTitolo.Text = "Park_City";
        	this.lblTitolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblPostiTotali
        	// 
        	this.lblPostiTotali.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        	this.lblPostiTotali.Location = new System.Drawing.Point(6, 20);
        	this.lblPostiTotali.Name = "lblPostiTotali";
        	this.lblPostiTotali.Size = new System.Drawing.Size(129, 23);
        	this.lblPostiTotali.TabIndex = 1;
        	this.lblPostiTotali.Text = "N° Posti Totali";
        	this.lblPostiTotali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// lbl_costo
        	// 
        	this.lbl_costo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        	this.lbl_costo.Location = new System.Drawing.Point(6, 22);
        	this.lbl_costo.Name = "lbl_costo";
        	this.lbl_costo.Size = new System.Drawing.Size(171, 23);
        	this.lbl_costo.TabIndex = 2;
        	this.lbl_costo.Text = "Costo Orario (€/ora)";
        	this.lbl_costo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// txt_posti_totali
        	// 
        	this.txt_posti_totali.ForeColor = System.Drawing.Color.Navy;
        	this.txt_posti_totali.Location = new System.Drawing.Point(141, 20);
        	this.txt_posti_totali.Name = "txt_posti_totali";
        	this.txt_posti_totali.Size = new System.Drawing.Size(100, 20);
        	this.txt_posti_totali.TabIndex = 3;
        	// 
        	// txt_costo
        	// 
        	this.txt_costo.ForeColor = System.Drawing.Color.Navy;
        	this.txt_costo.Location = new System.Drawing.Point(191, 23);
        	this.txt_costo.Name = "txt_costo";
        	this.txt_costo.Size = new System.Drawing.Size(45, 20);
        	this.txt_costo.TabIndex = 4;
        	// 
        	// group_box1
        	// 
        	this.group_box1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
        	this.group_box1.Controls.Add(this.txt_posti_disponibili);
        	this.group_box1.Controls.Add(this.txt_posti_occupati);
        	this.group_box1.Controls.Add(this.lblPostiDisponibili);
        	this.group_box1.Controls.Add(this.lblPostiOccupati);
        	this.group_box1.Controls.Add(this.txt_posti_totali);
        	this.group_box1.Controls.Add(this.lblPostiTotali);
        	this.group_box1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.group_box1.ForeColor = System.Drawing.Color.Navy;
        	this.group_box1.Location = new System.Drawing.Point(203, 83);
        	this.group_box1.Name = "group_box1";
        	this.group_box1.Size = new System.Drawing.Size(247, 124);
        	this.group_box1.TabIndex = 6;
        	this.group_box1.TabStop = false;
        	this.group_box1.Text = "DISPONIBILITA\' PARCHEGGIO";
        	// 
        	// txt_posti_disponibili
        	// 
        	this.txt_posti_disponibili.ForeColor = System.Drawing.Color.Navy;
        	this.txt_posti_disponibili.Location = new System.Drawing.Point(141, 89);
        	this.txt_posti_disponibili.Name = "txt_posti_disponibili";
        	this.txt_posti_disponibili.Size = new System.Drawing.Size(100, 20);
        	this.txt_posti_disponibili.TabIndex = 11;
        	// 
        	// txt_posti_occupati
        	// 
        	this.txt_posti_occupati.ForeColor = System.Drawing.Color.Navy;
        	this.txt_posti_occupati.Location = new System.Drawing.Point(141, 55);
        	this.txt_posti_occupati.Name = "txt_posti_occupati";
        	this.txt_posti_occupati.Size = new System.Drawing.Size(100, 20);
        	this.txt_posti_occupati.TabIndex = 10;
        	// 
        	// lblPostiDisponibili
        	// 
        	this.lblPostiDisponibili.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        	this.lblPostiDisponibili.Location = new System.Drawing.Point(5, 86);
        	this.lblPostiDisponibili.Name = "lblPostiDisponibili";
        	this.lblPostiDisponibili.Size = new System.Drawing.Size(129, 23);
        	this.lblPostiDisponibili.TabIndex = 7;
        	this.lblPostiDisponibili.Text = "N° Posti Disponibili";
        	this.lblPostiDisponibili.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// lblPostiOccupati
        	// 
        	this.lblPostiOccupati.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        	this.lblPostiOccupati.Location = new System.Drawing.Point(6, 52);
        	this.lblPostiOccupati.Name = "lblPostiOccupati";
        	this.lblPostiOccupati.Size = new System.Drawing.Size(129, 23);
        	this.lblPostiOccupati.TabIndex = 6;
        	this.lblPostiOccupati.Text = "N° Posti Occupati";
        	this.lblPostiOccupati.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// btnIngresso
        	// 
        	this.btnIngresso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnIngresso.ForeColor = System.Drawing.Color.Navy;
        	this.btnIngresso.Location = new System.Drawing.Point(42, 254);
        	this.btnIngresso.Name = "btnIngresso";
        	this.btnIngresso.Size = new System.Drawing.Size(200, 35);
        	this.btnIngresso.TabIndex = 7;
        	this.btnIngresso.Text = "INGRESSO";
        	this.btnIngresso.UseVisualStyleBackColor = true;
        	this.btnIngresso.Click += new System.EventHandler(this.btnIngresso_Click);
        	// 
        	// btn_Uscita
        	// 
        	this.btn_Uscita.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btn_Uscita.ForeColor = System.Drawing.Color.Navy;
        	this.btn_Uscita.Location = new System.Drawing.Point(250, 254);
        	this.btn_Uscita.Name = "btn_Uscita";
        	this.btn_Uscita.Size = new System.Drawing.Size(200, 35);
        	this.btn_Uscita.TabIndex = 8;
        	this.btn_Uscita.Text = "USCITA";
        	this.btn_Uscita.UseVisualStyleBackColor = true;
        	this.btn_Uscita.Click += new System.EventHandler(this.btnUscita_Click);
        	// 
        	// label2
        	// 
        	this.label2.BackColor = System.Drawing.Color.Blue;
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.ForeColor = System.Drawing.Color.White;
        	this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
        	this.label2.Location = new System.Drawing.Point(18, 15);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(40, 35);
        	this.label2.TabIndex = 9;
        	this.label2.Text = "P";
        	this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lbl_Disponibilità
        	// 
        	this.lbl_Disponibilità.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.lbl_Disponibilità.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lbl_Disponibilità.ForeColor = System.Drawing.Color.White;
        	this.lbl_Disponibilità.Location = new System.Drawing.Point(37, 116);
        	this.lbl_Disponibilità.Name = "lbl_Disponibilità";
        	this.lbl_Disponibilità.Size = new System.Drawing.Size(117, 74);
        	this.lbl_Disponibilità.TabIndex = 10;
        	this.lbl_Disponibilità.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        	// 
        	// lbl_Ingresso
        	// 
        	this.lbl_Ingresso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
        	this.lbl_Ingresso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.lbl_Ingresso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lbl_Ingresso.ForeColor = System.Drawing.Color.Navy;
        	this.lbl_Ingresso.Location = new System.Drawing.Point(42, 231);
        	this.lbl_Ingresso.Name = "lbl_Ingresso";
        	this.lbl_Ingresso.Size = new System.Drawing.Size(408, 20);
        	this.lbl_Ingresso.TabIndex = 13;
        	this.lbl_Ingresso.Text = "TICKET";
        	this.lbl_Ingresso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// group_box2
        	// 
        	this.group_box2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
        	this.group_box2.Controls.Add(this.txt_durata_sosta_oraria);
        	this.group_box2.Controls.Add(this.lblDurataSostaOraria);
        	this.group_box2.Controls.Add(this.txt_costo_giornaliero);
        	this.group_box2.Controls.Add(this.lblCostoGiornaliero);
        	this.group_box2.Controls.Add(this.lbl_costo);
        	this.group_box2.Controls.Add(this.txt_costo);
        	this.group_box2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.group_box2.ForeColor = System.Drawing.Color.Navy;
        	this.group_box2.Location = new System.Drawing.Point(35, 340);
        	this.group_box2.Name = "group_box2";
        	this.group_box2.Size = new System.Drawing.Size(247, 115);
        	this.group_box2.TabIndex = 15;
        	this.group_box2.TabStop = false;
        	this.group_box2.Text = "PARCHIMETRO PARCHEGGIO";
        	// 
        	// txt_durata_sosta_oraria
        	// 
        	this.txt_durata_sosta_oraria.ForeColor = System.Drawing.Color.Navy;
        	this.txt_durata_sosta_oraria.Location = new System.Drawing.Point(190, 80);
        	this.txt_durata_sosta_oraria.Name = "txt_durata_sosta_oraria";
        	this.txt_durata_sosta_oraria.Size = new System.Drawing.Size(45, 20);
        	this.txt_durata_sosta_oraria.TabIndex = 8;
        	// 
        	// lblDurataSostaOraria
        	// 
        	this.lblDurataSostaOraria.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        	this.lblDurataSostaOraria.Location = new System.Drawing.Point(7, 80);
        	this.lblDurataSostaOraria.Name = "lblDurataSostaOraria";
        	this.lblDurataSostaOraria.Size = new System.Drawing.Size(170, 23);
        	this.lblDurataSostaOraria.TabIndex = 7;
        	this.lblDurataSostaOraria.Text = "Durata Sosta Oraria (minuti)";
        	this.lblDurataSostaOraria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// txt_costo_giornaliero
        	// 
        	this.txt_costo_giornaliero.ForeColor = System.Drawing.Color.Navy;
        	this.txt_costo_giornaliero.Location = new System.Drawing.Point(190, 54);
        	this.txt_costo_giornaliero.Name = "txt_costo_giornaliero";
        	this.txt_costo_giornaliero.Size = new System.Drawing.Size(45, 20);
        	this.txt_costo_giornaliero.TabIndex = 6;
        	// 
        	// lblCostoGiornaliero
        	// 
        	this.lblCostoGiornaliero.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        	this.lblCostoGiornaliero.Location = new System.Drawing.Point(7, 52);
        	this.lblCostoGiornaliero.Name = "lblCostoGiornaliero";
        	this.lblCostoGiornaliero.Size = new System.Drawing.Size(170, 24);
        	this.lblCostoGiornaliero.TabIndex = 5;
        	this.lblCostoGiornaliero.Text = "Costo Giornaliero (€/giorno)";
        	this.lblCostoGiornaliero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// txt_data
        	// 
        	this.txt_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
        	this.txt_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
        	this.txt_data.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txt_data.ForeColor = System.Drawing.Color.Navy;
        	this.txt_data.Location = new System.Drawing.Point(298, 367);
        	this.txt_data.Name = "txt_data";
        	this.txt_data.Size = new System.Drawing.Size(146, 15);
        	this.txt_data.TabIndex = 7;
        	this.txt_data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        	// 
        	// lstServizi
        	// 
        	this.lstServizi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
        	this.lstServizi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lstServizi.ForeColor = System.Drawing.Color.Navy;
        	this.lstServizi.FormattingEnabled = true;
        	this.lstServizi.Location = new System.Drawing.Point(298, 383);
        	this.lstServizi.Name = "lstServizi";
        	this.lstServizi.Size = new System.Drawing.Size(146, 69);
        	this.lstServizi.TabIndex = 18;
        	// 
        	// lblServizi
        	// 
        	this.lblServizi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
        	this.lblServizi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblServizi.ForeColor = System.Drawing.Color.Navy;
        	this.lblServizi.Location = new System.Drawing.Point(298, 341);
        	this.lblServizi.Name = "lblServizi";
        	this.lblServizi.Size = new System.Drawing.Size(146, 23);
        	this.lblServizi.TabIndex = 19;
        	this.lblServizi.Text = "SERVZI PARCHEGGIO";
        	this.lblServizi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblSemaforo
        	// 
        	this.lblSemaforo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
        	this.lblSemaforo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblSemaforo.ForeColor = System.Drawing.Color.Navy;
        	this.lblSemaforo.Location = new System.Drawing.Point(38, 83);
        	this.lblSemaforo.Name = "lblSemaforo";
        	this.lblSemaforo.Size = new System.Drawing.Size(116, 29);
        	this.lblSemaforo.TabIndex = 26;
        	this.lblSemaforo.Text = "SEMAFORO INGRESSO";
        	this.lblSemaforo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// txtDisponibilità
        	// 
        	this.txtDisponibilità.BackColor = System.Drawing.SystemColors.Control;
        	this.txtDisponibilità.BorderStyle = System.Windows.Forms.BorderStyle.None;
        	this.txtDisponibilità.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtDisponibilità.Location = new System.Drawing.Point(37, 194);
        	this.txtDisponibilità.Name = "txtDisponibilità";
        	this.txtDisponibilità.Size = new System.Drawing.Size(116, 13);
        	this.txtDisponibilità.TabIndex = 27;
        	this.txtDisponibilità.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        	// 
        	// btnGestioneParcheggio
        	// 
        	this.btnGestioneParcheggio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnGestioneParcheggio.ForeColor = System.Drawing.Color.Navy;
        	this.btnGestioneParcheggio.Location = new System.Drawing.Point(35, 472);
        	this.btnGestioneParcheggio.Name = "btnGestioneParcheggio";
        	this.btnGestioneParcheggio.Size = new System.Drawing.Size(415, 25);
        	this.btnGestioneParcheggio.TabIndex = 28;
        	this.btnGestioneParcheggio.Text = "GESTIONE PARCHEGGIO";
        	this.btnGestioneParcheggio.UseVisualStyleBackColor = true;
        	this.btnGestioneParcheggio.Click += new System.EventHandler(this.BtnGestioneParcheggioClick);
        	// 
        	// lblInfo
        	// 
        	this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
        	this.lblInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblInfo.ForeColor = System.Drawing.Color.Navy;
        	this.lblInfo.Location = new System.Drawing.Point(37, 316);
        	this.lblInfo.Name = "lblInfo";
        	this.lblInfo.Size = new System.Drawing.Size(413, 17);
        	this.lblInfo.TabIndex = 29;
        	this.lblInfo.Text = "INFORMAZIONI";
        	this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblP2
        	// 
        	this.lblP2.BackColor = System.Drawing.Color.Blue;
        	this.lblP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblP2.ForeColor = System.Drawing.Color.White;
        	this.lblP2.Location = new System.Drawing.Point(427, 15);
        	this.lblP2.Name = "lblP2";
        	this.lblP2.Size = new System.Drawing.Size(40, 35);
        	this.lblP2.TabIndex = 30;
        	this.lblP2.Text = "P";
        	// 
        	// FormMain
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(478, 517);
        	this.Controls.Add(this.lblP2);
        	this.Controls.Add(this.lblInfo);
        	this.Controls.Add(this.btnGestioneParcheggio);
        	this.Controls.Add(this.txtDisponibilità);
        	this.Controls.Add(this.lblSemaforo);
        	this.Controls.Add(this.lblServizi);
        	this.Controls.Add(this.lstServizi);
        	this.Controls.Add(this.txt_data);
        	this.Controls.Add(this.group_box2);
        	this.Controls.Add(this.lbl_Ingresso);
        	this.Controls.Add(this.lbl_Disponibilità);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.btn_Uscita);
        	this.Controls.Add(this.btnIngresso);
        	this.Controls.Add(this.group_box1);
        	this.Controls.Add(this.lblTitolo);
        	this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.Name = "FormMain";
        	this.Text = "FormMain";
        	this.Load += new System.EventHandler(this.FormMain_Load);
        	this.group_box1.ResumeLayout(false);
        	this.group_box1.PerformLayout();
        	this.group_box2.ResumeLayout(false);
        	this.group_box2.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Label lblPostiTotali;
        private System.Windows.Forms.Label lbl_costo;
        private System.Windows.Forms.TextBox txt_posti_totali;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.GroupBox group_box1;
        private System.Windows.Forms.Button btn_Uscita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPostiOccupati;
        private System.Windows.Forms.Label lblPostiDisponibili;
        private System.Windows.Forms.TextBox txt_posti_disponibili;
        private System.Windows.Forms.TextBox txt_posti_occupati;
        private System.Windows.Forms.Label lbl_Disponibilità;
        private System.Windows.Forms.Label lbl_Ingresso;
        private System.Windows.Forms.Button btnIngresso;
        private System.Windows.Forms.GroupBox group_box2;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.ListBox lstServizi;
        private System.Windows.Forms.Label lblServizi;
        private System.Windows.Forms.Label lblCostoGiornaliero;
        private System.Windows.Forms.TextBox txt_costo_giornaliero;
        private System.Windows.Forms.Label lblSemaforo;
        private System.Windows.Forms.TextBox txtDisponibilità;
        private System.Windows.Forms.TextBox txt_durata_sosta_oraria;
        private System.Windows.Forms.Label lblDurataSostaOraria;
        private System.Windows.Forms.Button btnGestioneParcheggio;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblP2;
    }
}

