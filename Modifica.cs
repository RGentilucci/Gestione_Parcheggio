using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parcheggio
{
    public partial class Modifica : Form
    {
        //attributi
    	private int numeroPosti;
        private float costoOrario; 
        private float costoGiornaliero;
        private int durataSostaOraria;
        private string serviziAttivi;
        //variabile riferimento per l'implementazione del pattern singleton
        private static Modifica instance = null;
        
        //proprietà
        public int NumeroPosti
        {
        	get {return numeroPosti; }
        	set {numeroPosti = value;}
        }        
        public float CostoOrario
        {
            get {return costoOrario; }
        	set {costoOrario = value;}
        }        
         public float CostoGiornaliero
        {
            get {return costoGiornaliero; }
        	set {costoGiornaliero = value;}
        }         
         public int DurataSostaOraria
        {
        	get {return durataSostaOraria; }
        	set {durataSostaOraria = value;}
         }                  
         public string ServiziAttivi
        {
        	get {return serviziAttivi; }
        	set {serviziAttivi = value;}
         }        
         //costruttore
        public Modifica()
        {
            InitializeComponent();
        }       
         
        //metodi        
        //Implementazione del pattern singleton
        public static Modifica Instance()
        {
        	if (instance == null)
        		instance = new Modifica();
        	return instance;        
        }       
		//caricamento della FormModifica
		private void Modifica_Load(object sender, EventArgs e)
        { 
			Cparcheggio park 	= new Cparcheggio();
			park.Carica();
			txt_posti2.Text				= park.Posti_totali.ToString();
			txt_costo2.Text				= park.Costo_ora.ToString();
			txtCostoGiornaliero.Text	= park.Costo_giorno.ToString();
			txtDurataSostaOraria.Text	= park.Durata_Sosta_Oraria.ToString();
			txtServizi.Text				= park.Servizi_parcheggio;			
        }		
		//acquisizione dei nuovi dati tecnici del parcheggio
        private void btnOK_Click(object sender, EventArgs e)
        {
            numeroPosti 			= Convert.ToInt32(txt_posti2.Text);            
            costoOrario 			= Convert.ToSingle(txt_costo2.Text);
            costoGiornaliero 		= Convert.ToSingle(txtCostoGiornaliero.Text);
            durataSostaOraria		= Convert.ToInt32(txtDurataSostaOraria.Text);
            serviziAttivi 			= txtServizi.Text;
            DialogResult 			= DialogResult.OK;
            Close();
        }
      }
}
