using System;
using System.Drawing;
using System.Windows.Forms;

namespace Parcheggio
{	
	public partial class FormGestione : Form
	{
		//costruttore
		public FormGestione()
		{			
			InitializeComponent();			
		}
		
		//metodi
		//modifica dei parametri tecnici del parcheggio attraverso click del pulsante btnModificaParametri
		void BtnModificaParametriClick(object sender, EventArgs e)
		{
			//istanzizione della classi Modifica, FormMain, FormIngresso, Cparcheggio      	
        	Modifica fm 	= Modifica.Instance();  
        	FormMain fmain 	= FormMain.Instance();
        	FormIngresso fi	= new FormIngresso();        	
        	Cparcheggio park =new Cparcheggio();
        	
            if (fm.ShowDialog() == DialogResult.OK)
            {         	
            	//acquisizione dei nuovi parametri del parcheggio e registrazione su file di archivio
            	park.Posti_totali 		= fm.NumeroPosti;
            	park.Costo_ora 			= fm.CostoOrario;            	
            	park.Costo_giorno 		= fm.CostoGiornaliero;
            	park.Durata_Sosta_Oraria= fm.DurataSostaOraria;
            	park.Servizi_parcheggio = fm.ServiziAttivi;
                park.Salva();                
                //aggiornamento dei nuovi parametri del parcheggio nella dashboard 
                fmain.AggiornaFormModificaParametri(fi.Ne);
                Close();
			}	
		}		
		//elaborazioni dei dati del parcheggio al click del pulsante btnElaborazioniDati
		void BtnElaborazioneDatiClick(object sender, EventArgs e)
		{
			FormElaborazioni fe = new FormElaborazioni();
			fe.Show();	
			Close();
		}		
		//modifica della password di sistema al click del pulsante btnModificaPassword
		void BtnModificaPasswordClick(object sender, EventArgs e)
		{
			FormPassword fp = FormPassword.Instance();
			fp.Show();
			Close();
		}
		//chiusura della form al click del bottone btnAnnulla
		void BtnAnnullaClick(object sender, EventArgs e)
		{
			Close();
		}		
	}
}
