using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace Parcheggio
{
	
	public partial class FormElaborazioni : Form
	{		
		//attributi
		//generic list di oggetti di tipo Csosta	
		private List<Cdati> elaborazioni = new List<Cdati>();		
		private ListViewItem sostaItem;		
			
		//costruttore
		public FormElaborazioni()
		{
			InitializeComponent();						
		}			
		
		//metodi
		//acquisizione dei dati relativi alle soste nel parcheggio da file di archivio ed inserimento in Generic List<> elaborazioni
		public bool Carica ()
		{			
			StreamReader sr = new StreamReader("Archivio_Parcheggio.txt");
			while (! sr.EndOfStream)
			{
				//creazione di un oggetto di tipo Cdati
				Cdati dati_sosta = new Cdati();
				//inserimento dei dati nell'oggetto Cdati previa lettura da file di archivio				
            	dati_sosta.TargaMezzo		= sr.ReadLine();
            	dati_sosta.Tipo_Veicolo		= sr.ReadLine();
            	dati_sosta.TipoAlimentazione= sr.ReadLine();
            	dati_sosta.TipoSosta		= sr.ReadLine();
            	dati_sosta.DataIngresso		= sr.ReadLine();
            	dati_sosta.OraIngresso		= sr.ReadLine();	
            	dati_sosta.MinutiIngresso	= sr.ReadLine();
            	dati_sosta.OraUscita		= sr.ReadLine();	
            	dati_sosta.MinutiUscita		= sr.ReadLine();
            	dati_sosta.PrezzoBiglietto	= Convert.ToSingle(sr.ReadLine());
				//inserimento dinamico dell'oggetto di tipo Cdati nella Generic List<> elaborazioni            	
            	elaborazioni.Add(dati_sosta);
            }
            sr.Close();            
            return true;	
		}		
		//creazione e visualizzazione delle elaborazioni statistiche del parcheggio su base giornaliera
		void BtnConfermaClick(object sender, EventArgs e)
		{
			int numeroIngressi		= 0;		
			int automobili			= 0;
			int motociclette		= 0;
			int camper				= 0;
			int veicoloBenzina		= 0;
			int veicoloGasolio		= 0;
			int veicoloElettrico	= 0;
			int veicoloIbrido		= 0;
			int sostaGiornaliera	= 0;;
			int sostaOraria			= 0;
			float ricavi			= 0;
			string data;
			data = monthCalendar.SelectionRange.Start.ToShortDateString();			
			lstViewRiepilogo.Items.Clear();
			//ricerca per data delle soste effettuate nel parcheggio e creazione delle statistiche
			foreach (Cdati dati in elaborazioni)
			{
					if (dati.DataIngresso == data)
					{
						numeroIngressi++;
						ricavi = ricavi + dati.PrezzoBiglietto;
						if (dati.Tipo_Veicolo == "Automobile")
							automobili++;
						if (dati.Tipo_Veicolo == "Motocicletta")
							motociclette++;
						if (dati.Tipo_Veicolo == "Camper")
							camper++;	
						if (dati.TipoAlimentazione == "Benzina")
							veicoloBenzina++;	
						if (dati.TipoAlimentazione == "Gasolio")
							veicoloGasolio++;
						if (dati.TipoAlimentazione == "Elettrico")
							veicoloElettrico++;							
						if (dati.TipoAlimentazione == "Ibrido")
							veicoloIbrido++;	
						if (dati.TipoSosta == "oraria")
							sostaOraria++;
						if (dati.TipoSosta == "giornaliera")
							sostaGiornaliera++;	
						//inserimento valori delle soste all'interno della ListView sostaItem
						sostaItem = new ListViewItem();						
						sostaItem.Text = dati.TargaMezzo;
						sostaItem.SubItems.Add(dati.Tipo_Veicolo);
						sostaItem.SubItems.Add(dati.TipoAlimentazione);
						sostaItem.SubItems.Add(dati.TipoSosta);
						sostaItem.SubItems.Add(dati.OraIngresso);
						sostaItem.SubItems.Add(dati.MinutiIngresso);
						sostaItem.SubItems.Add(dati.OraUscita);
						sostaItem.SubItems.Add(dati.MinutiUscita);
						sostaItem.SubItems.Add(Convert.ToString(dati.PrezzoBiglietto));						
						lstViewRiepilogo.Items.Add(sostaItem);
					}					
				}			
			//visualizzazione delle statistiche
			txtNumeroIngressi.Text 		= numeroIngressi.ToString();
			txtRicavi.Text         		= ricavi.ToString();
			txtAutomobili.Text 			= automobili.ToString();
			txtMoto.Text 				= motociclette.ToString();
			txtCamper.Text 				= camper.ToString();
			txtBenzina.Text				= veicoloBenzina.ToString();
			txtGasolio.Text				= veicoloGasolio.ToString();
			txtElettrico.Text			= veicoloElettrico.ToString();
			txtIbrida.Text				= veicoloIbrido.ToString();
			txtSostaOraria.Text			= sostaOraria.ToString();
			txtSostaGiornaliera.Text 	= sostaGiornaliera.ToString();						
		}
		//acquisizione dei dati delle soste al caricamento della FormElaborazioni
		void FormElaborazioni_Load(object sender, EventArgs e)
		{	
			Carica();
		}		
	}	
}	


