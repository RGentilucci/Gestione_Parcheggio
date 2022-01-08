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
    public partial class FormUscita : Form
    {                      
        //attributi
    	private double prezzo = 0;
    	
    	//costruttore
		public FormUscita()
        {
            InitializeComponent();
        }    	
    	
		//metodi
		//caricamento della FormUscita      
        private void FormUscita_Load(object sender, EventArgs e)
        {           
        }    	
        // metodo per la ricerca di un veicolo (attraverso la targa) nella Collection List<> sosta
    	private int ricerca_mezzo (List<Csosta> elenco_mezzi, string targa_mezzo)
    	{
    		int i;
    		for (i = 0; (i < elenco_mezzi.Count && (elenco_mezzi[i].TargaMezzo != targa_mezzo)); i++);
    		return((i < elenco_mezzi.Count)? i : -1);    			
    	}        
    	//aggiornamento ed inserimento dei dati della sosta nella FormUscita attraverso il click del pulsante btnConferma
        private void btnConferma_Click(object sender, EventArgs e)
        {   
        	//ricerca del veicolo nella Collection List<>
        	FormIngresso fi = new FormIngresso();
        	int indice  = ricerca_mezzo(fi.Sosta, txtIngresso.Text);
        	if ( indice == -1)
        	{
        		MessageBox.Show("Veicolo non presente !! Inserire di nuovo targa veicolo");
        		txtIngresso.Clear();        	
        	}
        	else
        	{
        		//caricamento dei dati di ingresso del veicolo
        		txtOraIngresso.Text 	= fi.Sosta[indice].OraIngresso;
            	txtMinutiIngresso.Text 	= fi.Sosta[indice].MinutiIngresso;           
            	//inserimento dei dati di uscita del veicolo
            	txtOraUscita.Text 		= DateTime.Now.Hour.ToString();
            	txtMinutiUscita.Text 	= DateTime.Now.Minute.ToString();
            	//calcolo del tempo di permanenza nel parcheggio
            	int minutiUscita 	= (Convert.ToInt32(txtOraUscita.Text)*60) + Convert.ToInt32(txtMinutiUscita.Text);
        		int minutiIngresso 	=  (Convert.ToInt32(txtOraIngresso.Text)*60) + Convert.ToInt32(txtMinutiIngresso.Text);
        		int minutiSosta 	= minutiUscita - minutiIngresso;           	
				//calcolo del prezzo di permanenza del parcheggio
				Cparcheggio park = new Cparcheggio();
				park.Carica();				
				if (minutiSosta < park.Durata_Sosta_Oraria)
				{
					prezzo = minutiSosta * (park.Costo_ora/60);
					txtTipoSosta.Text = "oraria";
				}
            	else
            	{
            		prezzo = park.Costo_giorno;
            		txtTipoSosta.Text = "giornaliera";
            	}
            	txtPrezzo.Text = Convert.ToString(prezzo); 
            	//archiviazione su file di archivio di tutti i dati relativi alla sosta del veicolo             	
            	StreamWriter sw = File.AppendText("Archivio_Parcheggio.txt");            	
            	sw.WriteLine(fi.Sosta[indice].TargaMezzo);
            	sw.WriteLine(fi.Sosta[indice].Tipo_Veicolo);
            	sw.WriteLine(fi.Sosta[indice].TipoAlimentazione);
            	sw.WriteLine(txtTipoSosta.Text);
            	sw.WriteLine(fi.Sosta[indice].DataIngresso);
            	sw.WriteLine(fi.Sosta[indice].OraIngresso);
            	sw.WriteLine(fi.Sosta[indice].MinutiIngresso);
            	sw.WriteLine(txtOraUscita.Text);
            	sw.WriteLine(txtMinutiUscita.Text);
            	sw.WriteLine(txtPrezzo.Text);            	   		
            	sw.Close(); 
            	//rimozione dalla Collection List<> del veicolo in uscita del parcheggio
            	fi.Sosta.RemoveAt(indice); 
            	//decremento del numero di ingressi all'interno del parcheggio
            	fi.Ne--;
            	//aggiornamento della dashboard dopo una uscita nel parcheggio
            	FormMain fm = FormMain.Instance();
            	fm.AggiornaFormUscita(fi.Ne);
        	}        	
        }        	
		void BtnOKClick(object sender, EventArgs e)
		{
			Close();
		}       
    }
}
