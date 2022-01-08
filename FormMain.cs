using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Parcheggio
{
    public partial class FormMain : Form
    {        		
    	//attributi
		Cparcheggio park = new Cparcheggio();
		//variabile riferimento per l'implementazione del pattern singleton
		private static FormMain instance = null;		
		
		//costruttore    	 
    	public FormMain()
        {
            InitializeComponent();
        }
				
		//metodi
		//implementazione del pattern singleton
		public static FormMain Instance()
		{
			if (instance == null)
				instance = new FormMain();
			return instance;
		}	
		//aggiornamento della dashboard al caricamento della FormMain
        private void FormMain_Load(object sender, EventArgs e)
        {            
        	park.Carica();
            txt_posti_totali.Text 		= Convert.ToString(park.Posti_totali);
            txt_posti_occupati.Text 	= Convert.ToString (park.Posti_occupati);
            txt_posti_disponibili.Text 	= Convert.ToString (park.Posti_totali - park.Posti_occupati);
            txt_costo.Text 				= Convert.ToString(park.Costo_ora);
            txt_costo_giornaliero.Text 	= Convert.ToString(park.Costo_giorno);
            txt_durata_sosta_oraria.Text= Convert.ToString(park.Durata_Sosta_Oraria);
            txt_data.Text 				= DateTime.Today.ToShortDateString();
            //sincronizzazione del semaforo di ingresso relativo alla disponibilità del parcheggio
            if (park.Disponibilià(park.Posti_totali, park.Posti_occupati) == true)
            {
            	lbl_Disponibilità.BackColor = Color.Green;
            	txtDisponibilità.ForeColor	= Color.Green;
            	txtDisponibilità.Text 		= "LIBERO";
            }
            else
            {
            	lbl_Disponibilità.BackColor = Color.Red;
            	txtDisponibilità.ForeColor	= Color.Red;
            	txtDisponibilità.Text 		= "COMPLETO";
            }	
            //aggiornamento dei servizi attivi nel parcheggio nella list box lstServizi
            string [] servizi = park.Servizi_parcheggio.Split(',');
			foreach (string s in servizi)
				lstServizi.Items.Add(s);			
		 }			
        //ingresso di un veicolo attraverso il click del pulsante btnIngresso 
        private void btnIngresso_Click(object sender, EventArgs e)
        {        	
        	//caricamento della FormIngresso per l'inserimento dei dati di ingresso
        	FormIngresso fi = new FormIngresso();        	     
        	fi.Show();
        }
		//uscita di un veicolo attraverso il click del pulsante btnUscita 
        private void btnUscita_Click(object sender, EventArgs e)
        {            
        	//caricamento della FormUscita per l'inserimento dei dati di uscita
        	FormUscita fu = new FormUscita();
            fu.Show();			      	
        }        
		//attivazione delle funzionalità di gestione 
		void BtnGestioneParcheggioClick(object sender, EventArgs e)
		{
			FormProxyPassword fpp = new FormProxyPassword();
			fpp.Show();
		}		
		//funzione di aggiornamento della dashboard dopo un nuovo ingresso nel parcheggio
		public void AggiornaFormIngresso (int ne)
		{
			//aggiornamento della dashboard
			txt_posti_occupati.Text 	= Convert.ToString(ne);
        	txt_posti_disponibili.Text 	= Convert.ToString(park.Posti_totali - ne); 
			//sincronizzazione del semaforo di ingresso relativo alla disponibilità del parcheggio
            if (park.Disponibilià(park.Posti_totali, ne) == true)
            {
            	lbl_Disponibilità.BackColor = Color.Green;
            	txtDisponibilità.ForeColor	= Color.Green;
            	txtDisponibilità.Text 		= "LIBERO";
            }
            else
            {
            	lbl_Disponibilità.BackColor 	= Color.Red;
            	txtDisponibilità.ForeColor		= Color.Red;
            	txtDisponibilità.Text 			= "COMPLETO";
            	//disattivazione del pulsante di ingresso se il parcheggio risulta completo
            	btnIngresso.Enabled 			= false;				
            }            
		}		
		//funzione di aggiornamento della dashboard dopo una uscita dal parcheggio
		public void AggiornaFormUscita (int ne)
		{
			//aggiornamento della dashboard
        	txt_posti_occupati.Text 	= Convert.ToString(ne);
        	txt_posti_disponibili.Text 	= Convert.ToString(park.Posti_totali - ne);
            
            //sincronizzazione del semaforo di ingresso relativo alla disponibilità del parcheggio
            if (park.Disponibilià(park.Posti_totali, ne) == true)
            {
            	lbl_Disponibilità.BackColor 	= Color.Green;
            	txtDisponibilità.ForeColor		= Color.Green;
            	txtDisponibilità.Text 			= "LIBERO";
            	//attivazione del pulsante di ingresso se il parcheggio risulta disponibile a nuove soste
            	btnIngresso.Enabled 			= true;				
            }
            else
            {
            	lbl_Disponibilità.BackColor = Color.Red;
            	txtDisponibilità.ForeColor	= Color.Red;
            	txtDisponibilità.Text 		= "COMPLETO";            	
            }	            
		}		
		//funzione di aggiornamento della dashboard dopo la modifica dei parametri tecnici del parcheggio
		public void AggiornaFormModificaParametri (int ne)
		{
			//aggiornamento della dashboard
			park.Carica();
			txt_posti_totali.Text 		= Convert.ToString(park.Posti_totali);
			txt_posti_disponibili.Text 	= Convert.ToString (park.Posti_totali - Convert.ToInt32(txt_posti_occupati.Text));
			txt_costo.Text 				= Convert.ToString(park.Costo_ora);
            txt_costo_giornaliero.Text 	= Convert.ToString(park.Costo_giorno);
            txt_durata_sosta_oraria.Text= Convert.ToString(park.Durata_Sosta_Oraria);
			lstServizi.Items.Clear();
 			string [] servizi = park.Servizi_parcheggio.Split(',');
			foreach (string s in servizi)
				lstServizi.Items.Add(s); 			
			//sincronizzazione del semaforo di ingresso relativo alla disponibilità del parcheggio
            if (park.Disponibilià(park.Posti_totali, ne) == true)
            {
            	lbl_Disponibilità.BackColor 	= Color.Green;
            	txtDisponibilità.ForeColor		= Color.Green;
            	txtDisponibilità.Text 			= "LIBERO";
            	//attivazione del pulsante di ingresso se il parcheggio risulta disponibile a nuove soste
            	btnIngresso.Enabled 			= true;				
            }
            else
            {
            	lbl_Disponibilità.BackColor = Color.Red;
            	txtDisponibilità.ForeColor	= Color.Red;
            	txtDisponibilità.Text 		= "COMPLETO";
				//disattivazione del pulsante di ingresso se il parcheggio risulta completo
            	btnIngresso.Enabled 		= false;
            }		
         } 	
	}
 }
