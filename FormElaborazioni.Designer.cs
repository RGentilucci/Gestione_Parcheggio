/*
 * Created by SharpDevelop.
 * User: UID0803510
 * Date: 22/12/2021
 * Time: 11:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Parcheggio
{
	partial class FormElaborazioni
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblNumeroIngressi;
		private System.Windows.Forms.TextBox txtNumeroIngressi;
		private System.Windows.Forms.Button btnConferma;
		private System.Windows.Forms.Label lblRicavo;
		private System.Windows.Forms.TextBox txtRicavi;
		private System.Windows.Forms.Label lblAuto;
		private System.Windows.Forms.Label lblMoto;
		private System.Windows.Forms.Label lblCamper;
		private System.Windows.Forms.TextBox txtAutomobili;
		private System.Windows.Forms.TextBox txtMoto;
		private System.Windows.Forms.TextBox txtCamper;
		private System.Windows.Forms.GroupBox grpTipologiaVeicolo;
		private System.Windows.Forms.Label lblParcheggio;
		private System.Windows.Forms.Label lblP1;
		private System.Windows.Forms.MonthCalendar monthCalendar;
		private System.Windows.Forms.Label lblSelezione;
		private System.Windows.Forms.Label lblP2;
		private System.Windows.Forms.TextBox txtSostaGiornaliera;
		private System.Windows.Forms.Label lblSostaGiornaliera;
		private System.Windows.Forms.TextBox txtSostaOraria;
		private System.Windows.Forms.Label lblSostaOraria;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtIbrida;
		private System.Windows.Forms.TextBox txtElettrico;
		private System.Windows.Forms.TextBox txtGasolio;
		private System.Windows.Forms.TextBox txtBenzina;
		private System.Windows.Forms.Label lblIbrida;
		private System.Windows.Forms.Label lblElettrica;
		private System.Windows.Forms.Label lblGasolio;
		private System.Windows.Forms.Label lblBenzina;
		private System.Windows.Forms.Label lblTipoSosta;
		private System.Windows.Forms.Label lblTipologiaMotore;
		private System.Windows.Forms.Label lblTipoVeicolo;
		private System.Windows.Forms.Label lblElaborazioni;
		private System.Windows.Forms.ListView lstViewRiepilogo;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.Label lblAnalitica;
		private System.Windows.Forms.GroupBox grpTipologiaAlimentazione;
		private System.Windows.Forms.GroupBox grpTipologiaSosta;
		private System.Windows.Forms.GroupBox grpRicavi;
		
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
			this.lblNumeroIngressi = new System.Windows.Forms.Label();
			this.txtNumeroIngressi = new System.Windows.Forms.TextBox();
			this.btnConferma = new System.Windows.Forms.Button();
			this.lblRicavo = new System.Windows.Forms.Label();
			this.txtRicavi = new System.Windows.Forms.TextBox();
			this.lblAuto = new System.Windows.Forms.Label();
			this.lblMoto = new System.Windows.Forms.Label();
			this.lblCamper = new System.Windows.Forms.Label();
			this.txtAutomobili = new System.Windows.Forms.TextBox();
			this.txtMoto = new System.Windows.Forms.TextBox();
			this.txtCamper = new System.Windows.Forms.TextBox();
			this.grpTipologiaVeicolo = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtIbrida = new System.Windows.Forms.TextBox();
			this.txtElettrico = new System.Windows.Forms.TextBox();
			this.txtGasolio = new System.Windows.Forms.TextBox();
			this.txtBenzina = new System.Windows.Forms.TextBox();
			this.lblIbrida = new System.Windows.Forms.Label();
			this.lblElettrica = new System.Windows.Forms.Label();
			this.lblGasolio = new System.Windows.Forms.Label();
			this.lblBenzina = new System.Windows.Forms.Label();
			this.lblTipoSosta = new System.Windows.Forms.Label();
			this.lblTipologiaMotore = new System.Windows.Forms.Label();
			this.lblTipoVeicolo = new System.Windows.Forms.Label();
			this.txtSostaGiornaliera = new System.Windows.Forms.TextBox();
			this.lblSostaGiornaliera = new System.Windows.Forms.Label();
			this.txtSostaOraria = new System.Windows.Forms.TextBox();
			this.lblSostaOraria = new System.Windows.Forms.Label();
			this.lblParcheggio = new System.Windows.Forms.Label();
			this.lblP1 = new System.Windows.Forms.Label();
			this.monthCalendar = new System.Windows.Forms.MonthCalendar();
			this.lblSelezione = new System.Windows.Forms.Label();
			this.lblP2 = new System.Windows.Forms.Label();
			this.lblElaborazioni = new System.Windows.Forms.Label();
			this.lstViewRiepilogo = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
			this.lblAnalitica = new System.Windows.Forms.Label();
			this.grpTipologiaAlimentazione = new System.Windows.Forms.GroupBox();
			this.grpTipologiaSosta = new System.Windows.Forms.GroupBox();
			this.grpRicavi = new System.Windows.Forms.GroupBox();
			this.grpTipologiaVeicolo.SuspendLayout();
			this.grpTipologiaAlimentazione.SuspendLayout();
			this.grpTipologiaSosta.SuspendLayout();
			this.grpRicavi.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblNumeroIngressi
			// 
			this.lblNumeroIngressi.Location = new System.Drawing.Point(16, 23);
			this.lblNumeroIngressi.Name = "lblNumeroIngressi";
			this.lblNumeroIngressi.Size = new System.Drawing.Size(98, 16);
			this.lblNumeroIngressi.TabIndex = 4;
			this.lblNumeroIngressi.Text = "Numero Soste";
			// 
			// txtNumeroIngressi
			// 
			this.txtNumeroIngressi.Location = new System.Drawing.Point(141, 22);
			this.txtNumeroIngressi.Name = "txtNumeroIngressi";
			this.txtNumeroIngressi.Size = new System.Drawing.Size(69, 20);
			this.txtNumeroIngressi.TabIndex = 5;
			// 
			// btnConferma
			// 
			this.btnConferma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnConferma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConferma.ForeColor = System.Drawing.Color.Navy;
			this.btnConferma.Location = new System.Drawing.Point(46, 273);
			this.btnConferma.Name = "btnConferma";
			this.btnConferma.Size = new System.Drawing.Size(228, 34);
			this.btnConferma.TabIndex = 6;
			this.btnConferma.Text = "CONFERMA";
			this.btnConferma.UseVisualStyleBackColor = false;
			this.btnConferma.Click += new System.EventHandler(this.BtnConfermaClick);
			// 
			// lblRicavo
			// 
			this.lblRicavo.Location = new System.Drawing.Point(6, 35);
			this.lblRicavo.Name = "lblRicavo";
			this.lblRicavo.Size = new System.Drawing.Size(98, 20);
			this.lblRicavo.TabIndex = 7;
			this.lblRicavo.Text = "Ricavi (€)";
			// 
			// txtRicavi
			// 
			this.txtRicavi.Location = new System.Drawing.Point(136, 32);
			this.txtRicavi.Name = "txtRicavi";
			this.txtRicavi.Size = new System.Drawing.Size(69, 20);
			this.txtRicavi.TabIndex = 8;
			// 
			// lblAuto
			// 
			this.lblAuto.Location = new System.Drawing.Point(14, 58);
			this.lblAuto.Name = "lblAuto";
			this.lblAuto.Size = new System.Drawing.Size(77, 23);
			this.lblAuto.TabIndex = 11;
			this.lblAuto.Text = "Automobili";
			this.lblAuto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblMoto
			// 
			this.lblMoto.Location = new System.Drawing.Point(13, 80);
			this.lblMoto.Name = "lblMoto";
			this.lblMoto.Size = new System.Drawing.Size(85, 23);
			this.lblMoto.TabIndex = 12;
			this.lblMoto.Text = "Motociclette";
			this.lblMoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblCamper
			// 
			this.lblCamper.Location = new System.Drawing.Point(14, 101);
			this.lblCamper.Name = "lblCamper";
			this.lblCamper.Size = new System.Drawing.Size(85, 23);
			this.lblCamper.TabIndex = 13;
			this.lblCamper.Text = "Camper";
			this.lblCamper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtAutomobili
			// 
			this.txtAutomobili.Location = new System.Drawing.Point(141, 60);
			this.txtAutomobili.Name = "txtAutomobili";
			this.txtAutomobili.Size = new System.Drawing.Size(68, 20);
			this.txtAutomobili.TabIndex = 14;
			// 
			// txtMoto
			// 
			this.txtMoto.Location = new System.Drawing.Point(141, 83);
			this.txtMoto.Name = "txtMoto";
			this.txtMoto.Size = new System.Drawing.Size(68, 20);
			this.txtMoto.TabIndex = 15;
			// 
			// txtCamper
			// 
			this.txtCamper.Location = new System.Drawing.Point(141, 106);
			this.txtCamper.Name = "txtCamper";
			this.txtCamper.Size = new System.Drawing.Size(68, 20);
			this.txtCamper.TabIndex = 16;
			// 
			// grpTipologiaVeicolo
			// 
			this.grpTipologiaVeicolo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.grpTipologiaVeicolo.Controls.Add(this.lblTipoVeicolo);
			this.grpTipologiaVeicolo.Controls.Add(this.lblAuto);
			this.grpTipologiaVeicolo.Controls.Add(this.txtCamper);
			this.grpTipologiaVeicolo.Controls.Add(this.txtAutomobili);
			this.grpTipologiaVeicolo.Controls.Add(this.lblCamper);
			this.grpTipologiaVeicolo.Controls.Add(this.txtMoto);
			this.grpTipologiaVeicolo.Controls.Add(this.lblMoto);
			this.grpTipologiaVeicolo.Controls.Add(this.lblNumeroIngressi);
			this.grpTipologiaVeicolo.Controls.Add(this.txtNumeroIngressi);
			this.grpTipologiaVeicolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpTipologiaVeicolo.ForeColor = System.Drawing.Color.Navy;
			this.grpTipologiaVeicolo.Location = new System.Drawing.Point(326, 87);
			this.grpTipologiaVeicolo.Name = "grpTipologiaVeicolo";
			this.grpTipologiaVeicolo.Size = new System.Drawing.Size(225, 133);
			this.grpTipologiaVeicolo.TabIndex = 17;
			this.grpTipologiaVeicolo.TabStop = false;
			this.grpTipologiaVeicolo.Text = "Elaborazione Dati Parcheggio";
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(6, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 32;
			this.label1.Text = "Ricavi";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtIbrida
			// 
			this.txtIbrida.Location = new System.Drawing.Point(139, 105);
			this.txtIbrida.Name = "txtIbrida";
			this.txtIbrida.Size = new System.Drawing.Size(70, 20);
			this.txtIbrida.TabIndex = 31;
			// 
			// txtElettrico
			// 
			this.txtElettrico.Location = new System.Drawing.Point(139, 81);
			this.txtElettrico.Name = "txtElettrico";
			this.txtElettrico.Size = new System.Drawing.Size(69, 20);
			this.txtElettrico.TabIndex = 30;
			// 
			// txtGasolio
			// 
			this.txtGasolio.Location = new System.Drawing.Point(140, 58);
			this.txtGasolio.Name = "txtGasolio";
			this.txtGasolio.Size = new System.Drawing.Size(69, 20);
			this.txtGasolio.TabIndex = 29;
			// 
			// txtBenzina
			// 
			this.txtBenzina.Location = new System.Drawing.Point(139, 35);
			this.txtBenzina.Name = "txtBenzina";
			this.txtBenzina.Size = new System.Drawing.Size(70, 20);
			this.txtBenzina.TabIndex = 28;
			// 
			// lblIbrida
			// 
			this.lblIbrida.Location = new System.Drawing.Point(15, 101);
			this.lblIbrida.Name = "lblIbrida";
			this.lblIbrida.Size = new System.Drawing.Size(100, 23);
			this.lblIbrida.TabIndex = 27;
			this.lblIbrida.Text = "Ibrida";
			this.lblIbrida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblElettrica
			// 
			this.lblElettrica.Location = new System.Drawing.Point(15, 81);
			this.lblElettrica.Name = "lblElettrica";
			this.lblElettrica.Size = new System.Drawing.Size(100, 23);
			this.lblElettrica.TabIndex = 26;
			this.lblElettrica.Text = "Elettrica";
			this.lblElettrica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblGasolio
			// 
			this.lblGasolio.Location = new System.Drawing.Point(15, 58);
			this.lblGasolio.Name = "lblGasolio";
			this.lblGasolio.Size = new System.Drawing.Size(100, 23);
			this.lblGasolio.TabIndex = 25;
			this.lblGasolio.Text = "Gasolio";
			this.lblGasolio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblBenzina
			// 
			this.lblBenzina.Location = new System.Drawing.Point(15, 35);
			this.lblBenzina.Name = "lblBenzina";
			this.lblBenzina.Size = new System.Drawing.Size(100, 23);
			this.lblBenzina.TabIndex = 24;
			this.lblBenzina.Text = "Benzina";
			this.lblBenzina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTipoSosta
			// 
			this.lblTipoSosta.ForeColor = System.Drawing.Color.White;
			this.lblTipoSosta.Location = new System.Drawing.Point(6, 17);
			this.lblTipoSosta.Name = "lblTipoSosta";
			this.lblTipoSosta.Size = new System.Drawing.Size(100, 23);
			this.lblTipoSosta.TabIndex = 23;
			this.lblTipoSosta.Text = "Tipologia Sosta";
			this.lblTipoSosta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTipologiaMotore
			// 
			this.lblTipologiaMotore.ForeColor = System.Drawing.Color.White;
			this.lblTipologiaMotore.Location = new System.Drawing.Point(6, 12);
			this.lblTipologiaMotore.Name = "lblTipologiaMotore";
			this.lblTipologiaMotore.Size = new System.Drawing.Size(188, 23);
			this.lblTipologiaMotore.TabIndex = 22;
			this.lblTipologiaMotore.Text = "Tipologia Alimentazione Motore";
			this.lblTipologiaMotore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTipoVeicolo
			// 
			this.lblTipoVeicolo.ForeColor = System.Drawing.Color.White;
			this.lblTipoVeicolo.Location = new System.Drawing.Point(13, 40);
			this.lblTipoVeicolo.Name = "lblTipoVeicolo";
			this.lblTipoVeicolo.Size = new System.Drawing.Size(192, 23);
			this.lblTipoVeicolo.TabIndex = 21;
			this.lblTipoVeicolo.Text = "Tipologia Veicolo";
			this.lblTipoVeicolo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtSostaGiornaliera
			// 
			this.txtSostaGiornaliera.Location = new System.Drawing.Point(139, 59);
			this.txtSostaGiornaliera.Name = "txtSostaGiornaliera";
			this.txtSostaGiornaliera.Size = new System.Drawing.Size(69, 20);
			this.txtSostaGiornaliera.TabIndex = 20;
			// 
			// lblSostaGiornaliera
			// 
			this.lblSostaGiornaliera.Location = new System.Drawing.Point(4, 58);
			this.lblSostaGiornaliera.Name = "lblSostaGiornaliera";
			this.lblSostaGiornaliera.Size = new System.Drawing.Size(104, 23);
			this.lblSostaGiornaliera.TabIndex = 19;
			this.lblSostaGiornaliera.Text = "Sosta Giornaliera";
			this.lblSostaGiornaliera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtSostaOraria
			// 
			this.txtSostaOraria.Location = new System.Drawing.Point(139, 35);
			this.txtSostaOraria.Name = "txtSostaOraria";
			this.txtSostaOraria.Size = new System.Drawing.Size(69, 20);
			this.txtSostaOraria.TabIndex = 18;
			// 
			// lblSostaOraria
			// 
			this.lblSostaOraria.Location = new System.Drawing.Point(4, 35);
			this.lblSostaOraria.Name = "lblSostaOraria";
			this.lblSostaOraria.Size = new System.Drawing.Size(100, 23);
			this.lblSostaOraria.TabIndex = 17;
			this.lblSostaOraria.Text = "Sosta Oraria";
			this.lblSostaOraria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblParcheggio
			// 
			this.lblParcheggio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblParcheggio.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
			this.lblParcheggio.ForeColor = System.Drawing.Color.Navy;
			this.lblParcheggio.Location = new System.Drawing.Point(22, 13);
			this.lblParcheggio.Name = "lblParcheggio";
			this.lblParcheggio.Size = new System.Drawing.Size(574, 38);
			this.lblParcheggio.TabIndex = 18;
			this.lblParcheggio.Text = "Park_City";
			this.lblParcheggio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblP1
			// 
			this.lblP1.BackColor = System.Drawing.Color.Blue;
			this.lblP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblP1.ForeColor = System.Drawing.Color.White;
			this.lblP1.Location = new System.Drawing.Point(29, 19);
			this.lblP1.Name = "lblP1";
			this.lblP1.Size = new System.Drawing.Size(30, 30);
			this.lblP1.TabIndex = 19;
			this.lblP1.Text = "P";
			// 
			// monthCalendar
			// 
			this.monthCalendar.BackColor = System.Drawing.Color.White;
			this.monthCalendar.ForeColor = System.Drawing.Color.Black;
			this.monthCalendar.Location = new System.Drawing.Point(47, 110);
			this.monthCalendar.Name = "monthCalendar";
			this.monthCalendar.TabIndex = 20;
			// 
			// lblSelezione
			// 
			this.lblSelezione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.lblSelezione.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSelezione.ForeColor = System.Drawing.Color.Navy;
			this.lblSelezione.Location = new System.Drawing.Point(47, 93);
			this.lblSelezione.Name = "lblSelezione";
			this.lblSelezione.Size = new System.Drawing.Size(227, 23);
			this.lblSelezione.TabIndex = 21;
			this.lblSelezione.Text = "Seleziona Data";
			this.lblSelezione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblP2
			// 
			this.lblP2.BackColor = System.Drawing.Color.Blue;
			this.lblP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblP2.ForeColor = System.Drawing.Color.White;
			this.lblP2.Location = new System.Drawing.Point(561, 18);
			this.lblP2.Name = "lblP2";
			this.lblP2.Size = new System.Drawing.Size(30, 30);
			this.lblP2.TabIndex = 22;
			this.lblP2.Text = "P";
			// 
			// lblElaborazioni
			// 
			this.lblElaborazioni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.lblElaborazioni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblElaborazioni.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblElaborazioni.ForeColor = System.Drawing.Color.Navy;
			this.lblElaborazioni.Location = new System.Drawing.Point(22, 57);
			this.lblElaborazioni.Name = "lblElaborazioni";
			this.lblElaborazioni.Size = new System.Drawing.Size(567, 23);
			this.lblElaborazioni.TabIndex = 23;
			this.lblElaborazioni.Text = "ELABORAZIONE DEI DATI";
			this.lblElaborazioni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lstViewRiepilogo
			// 
			this.lstViewRiepilogo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnHeader1,
			this.columnHeader2,
			this.columnHeader3,
			this.columnHeader4,
			this.columnHeader5,
			this.columnHeader6,
			this.columnHeader7,
			this.columnHeader8,
			this.columnHeader9});
			this.lstViewRiepilogo.FullRowSelect = true;
			this.lstViewRiepilogo.GridLines = true;
			this.lstViewRiepilogo.Location = new System.Drawing.Point(13, 468);
			this.lstViewRiepilogo.Name = "lstViewRiepilogo";
			this.lstViewRiepilogo.Size = new System.Drawing.Size(569, 134);
			this.lstViewRiepilogo.TabIndex = 24;
			this.lstViewRiepilogo.UseCompatibleStateImageBehavior = false;
			this.lstViewRiepilogo.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Targa";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Veicolo";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 88;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Motore";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Sosta";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Ora IN";
			this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader5.Width = 51;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Minuti IN";
			this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader6.Width = 56;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Ora OUT";
			this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader7.Width = 56;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Minuti OUT";
			this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader8.Width = 71;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Prezzo";
			this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader9.Width = 78;
			// 
			// lblAnalitica
			// 
			this.lblAnalitica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.lblAnalitica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAnalitica.ForeColor = System.Drawing.Color.Navy;
			this.lblAnalitica.Location = new System.Drawing.Point(13, 442);
			this.lblAnalitica.Name = "lblAnalitica";
			this.lblAnalitica.Size = new System.Drawing.Size(569, 23);
			this.lblAnalitica.TabIndex = 25;
			this.lblAnalitica.Text = "Dettaglio Analitico Soste Giornaliere Parcheggio";
			this.lblAnalitica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// grpTipologiaAlimentazione
			// 
			this.grpTipologiaAlimentazione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.grpTipologiaAlimentazione.Controls.Add(this.lblTipologiaMotore);
			this.grpTipologiaAlimentazione.Controls.Add(this.txtIbrida);
			this.grpTipologiaAlimentazione.Controls.Add(this.lblBenzina);
			this.grpTipologiaAlimentazione.Controls.Add(this.txtElettrico);
			this.grpTipologiaAlimentazione.Controls.Add(this.lblGasolio);
			this.grpTipologiaAlimentazione.Controls.Add(this.txtGasolio);
			this.grpTipologiaAlimentazione.Controls.Add(this.lblElettrica);
			this.grpTipologiaAlimentazione.Controls.Add(this.txtBenzina);
			this.grpTipologiaAlimentazione.Controls.Add(this.lblIbrida);
			this.grpTipologiaAlimentazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpTipologiaAlimentazione.ForeColor = System.Drawing.Color.Navy;
			this.grpTipologiaAlimentazione.Location = new System.Drawing.Point(326, 225);
			this.grpTipologiaAlimentazione.Name = "grpTipologiaAlimentazione";
			this.grpTipologiaAlimentazione.Size = new System.Drawing.Size(225, 130);
			this.grpTipologiaAlimentazione.TabIndex = 26;
			this.grpTipologiaAlimentazione.TabStop = false;
			this.grpTipologiaAlimentazione.Text = "Elaborazione Dati Parcheggio";
			// 
			// grpTipologiaSosta
			// 
			this.grpTipologiaSosta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.grpTipologiaSosta.Controls.Add(this.lblTipoSosta);
			this.grpTipologiaSosta.Controls.Add(this.txtSostaGiornaliera);
			this.grpTipologiaSosta.Controls.Add(this.lblSostaGiornaliera);
			this.grpTipologiaSosta.Controls.Add(this.txtSostaOraria);
			this.grpTipologiaSosta.Controls.Add(this.lblSostaOraria);
			this.grpTipologiaSosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpTipologiaSosta.ForeColor = System.Drawing.Color.Navy;
			this.grpTipologiaSosta.Location = new System.Drawing.Point(50, 325);
			this.grpTipologiaSosta.Name = "grpTipologiaSosta";
			this.grpTipologiaSosta.Size = new System.Drawing.Size(225, 87);
			this.grpTipologiaSosta.TabIndex = 27;
			this.grpTipologiaSosta.TabStop = false;
			this.grpTipologiaSosta.Text = "Elaborazione Dati Parcheggio";
			// 
			// grpRicavi
			// 
			this.grpRicavi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.grpRicavi.Controls.Add(this.label1);
			this.grpRicavi.Controls.Add(this.txtRicavi);
			this.grpRicavi.Controls.Add(this.lblRicavo);
			this.grpRicavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpRicavi.ForeColor = System.Drawing.Color.Navy;
			this.grpRicavi.Location = new System.Drawing.Point(326, 359);
			this.grpRicavi.Name = "grpRicavi";
			this.grpRicavi.Size = new System.Drawing.Size(225, 59);
			this.grpRicavi.TabIndex = 28;
			this.grpRicavi.TabStop = false;
			this.grpRicavi.Text = "Elaborazione Dati Parcheggio";
			// 
			// FormElaborazioni
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(608, 626);
			this.Controls.Add(this.grpRicavi);
			this.Controls.Add(this.grpTipologiaSosta);
			this.Controls.Add(this.grpTipologiaAlimentazione);
			this.Controls.Add(this.lblAnalitica);
			this.Controls.Add(this.lstViewRiepilogo);
			this.Controls.Add(this.lblElaborazioni);
			this.Controls.Add(this.lblP2);
			this.Controls.Add(this.lblSelezione);
			this.Controls.Add(this.monthCalendar);
			this.Controls.Add(this.lblP1);
			this.Controls.Add(this.lblParcheggio);
			this.Controls.Add(this.grpTipologiaVeicolo);
			this.Controls.Add(this.btnConferma);
			this.Name = "FormElaborazioni";
			this.Text = "FormElaborazioni";
			this.Load += new System.EventHandler(this.FormElaborazioni_Load);
			this.grpTipologiaVeicolo.ResumeLayout(false);
			this.grpTipologiaVeicolo.PerformLayout();
			this.grpTipologiaAlimentazione.ResumeLayout(false);
			this.grpTipologiaAlimentazione.PerformLayout();
			this.grpTipologiaSosta.ResumeLayout(false);
			this.grpTipologiaSosta.PerformLayout();
			this.grpRicavi.ResumeLayout(false);
			this.grpRicavi.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
