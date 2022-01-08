using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;


namespace Parcheggio
{	
	public partial class FormIngresso : Form
	{
		//attributi 
		private static int ne = 0;
		//collection list<> di elementi Csosta (lista tipizzata)
		private static List<Csosta> sosta = new List<Csosta>();
						
		//proprietà
		public int Ne
        {
            get {return ne;}
            set { ne = value;}
        }
		public List<Csosta> Sosta
        {
            get {return sosta;}           
        }		
		
		//costruttore
		public FormIngresso()
		{
			InitializeComponent();
		}		
		
		//metodi		
		//caricamento ed aggiornamento della FormIngresso per l'inserimento dei dati di ingresso al parcheggio
		private void FormIngresso_Load(object sender, EventArgs e)
        {                      
            txtData.Text				= DateTime.Today.ToShortDateString();
            txtOra.Text					= DateTime.Now.Hour.ToString();
            txtMinuti.Text				= DateTime.Now.Minute.ToString();                     
         }		
		//inserimento dei dati di ciascuna sosta all'interno della Collection List<> sosta
		void BtnConfermaClick(object sender, EventArgs e)
		{
			if (txtTarga.Text.Length > 0 & cmbTipo.Text.Length > 0 & cmbTipoMotore.Text.Length > 0)
			{
			//creazione dell'oggetto di tipo Csosta
			Csosta sostaCliente = new Csosta();		
			//inserimento dei dati nell'oggetto di tipo Csosta            
            sostaCliente.DataIngresso			= txtData.Text;
            sostaCliente.OraIngresso			= txtOra.Text;
            sostaCliente.MinutiIngresso			= txtMinuti.Text;
            sostaCliente.TargaMezzo				= txtTarga.Text;
            sostaCliente.Tipo_Veicolo			= cmbTipo.Text;
            sostaCliente.TipoAlimentazione		= cmbTipoMotore.Text;                      
            //inserimento dell'oggetto Csosta nella Collection List<> sosta
            sosta.Add(sostaCliente);     
            Close();         
            //incremento del numero di ingressi all'interno del parcheggio
            ne++;
            //aggiornamento della dashboard dopo un nuovo ingresso nel parcheggio
            FormMain fm = FormMain.Instance();
            fm.AggiornaFormIngresso(ne);
			}
			else
				MessageBox.Show("Inserire tutti i dati richiesti !!");        		       	
		}
	}
}
