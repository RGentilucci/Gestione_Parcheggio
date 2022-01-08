using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Parcheggio
{
    class Cparcheggio
    {
        //attributi
        private int posti_totali; 
        private int posti_occupati;
        private float costo_ora;
        private float costo_giorno;
        private int durata_sosta_oraria;
        private string servizi_parcheggio;
        
        //proprieta'
        public int Posti_totali
        {
            get {return posti_totali;}
            set { posti_totali = value;}
        }        
        public float Costo_ora
        {
            get { return costo_ora; }
            set { costo_ora = value; }
        }
        public float Costo_giorno
        {
            get { return costo_giorno; }
            set { costo_giorno = value; }
        }
        public int Posti_occupati
        {
            get {return posti_occupati;}
            set { posti_occupati = value;}
        }        
         public int Durata_Sosta_Oraria
        {
            get {return durata_sosta_oraria;}
            set { durata_sosta_oraria = value;}
        }                 
		 public string Servizi_parcheggio
        {
            get {return servizi_parcheggio;}
            set { servizi_parcheggio = value;}
        }
        
        //costruttore esplicito
        public Cparcheggio()
        {
        	posti_occupati = 0;
        }
       
        //metodi
		//metodo per salvare sull'archivio relativo ai dati tecnici del parcheggio        
        public bool Salva()
        {
            StreamWriter sw = new StreamWriter("Parcheggio.txt");
            sw.WriteLine(posti_totali);
            sw.WriteLine(costo_ora);
            sw.WriteLine(costo_giorno);
            sw.WriteLine(durata_sosta_oraria);
            sw.WriteLine(servizi_parcheggio);
            sw.Close();
            return true;
        }		
        //metodo per leggere dall'archivio relativo ai dati tecnici del parcheggio 
        public bool Carica()
        {
            StreamReader sr 	= new StreamReader("Parcheggio.txt");
            posti_totali 		= Convert.ToInt32(sr.ReadLine());
            costo_ora 			= Convert.ToSingle(sr.ReadLine());
            costo_giorno 		= Convert.ToSingle(sr.ReadLine());
            durata_sosta_oraria = Convert.ToInt32(sr.ReadLine());
            servizi_parcheggio 	= (sr.ReadLine());
            sr.Close();
            return true;
        }
        //metodo per verificare la disponibilità del parcheggio (se libero o completo)	
        public bool Disponibilià (int postiTotali, int postiOccupati)
        {        
        	if (postiOccupati < postiTotali)
        		return true;
        	else
        		return false;        
        }        
    }
}
