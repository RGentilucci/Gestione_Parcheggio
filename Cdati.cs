using System;

namespace Parcheggio
{
	
	public class Cdati
	{		
		//attributi		
		private string dataIngresso;
		private string oraIngresso;
		private string minutiIngresso;
		private string oraUscita;
		private string minutiUscita;		
		private string targaMezzo;
		private string tipo_Veicolo;
		private string tipoAlimentazione;
		private string tipoSosta;
		private	float prezzoBiglietto;
	
		//proprieta'		
		public string DataIngresso
        {
            get {return dataIngresso;}
            set { dataIngresso = value;}
        }		
		public string OraIngresso
        {
            get {return oraIngresso;}
            set { oraIngresso = value;}
        }		
		public string MinutiIngresso
        {
            get {return minutiIngresso;}
            set { minutiIngresso = value;}
        }		
		public string OraUscita
        {
            get {return oraUscita;}
            set { oraUscita = value;}
        }		
		public string MinutiUscita
        {
            get {return minutiUscita;}
            set { minutiUscita = value;}
		}				
		public string TargaMezzo
        {
            get {return targaMezzo;}
            set {targaMezzo = value;}
        }		
		public string Tipo_Veicolo
        {
            get {return tipo_Veicolo;}
            set { tipo_Veicolo = value;}
        }		
		public string TipoAlimentazione
        {
            get {return tipoAlimentazione;}
            set { tipoAlimentazione = value;}
        }		
		public string TipoSosta
        {
            get {return tipoSosta;}
            set { tipoSosta = value;}
        }		
		public float PrezzoBiglietto
		{
            get {return prezzoBiglietto;}
            set { prezzoBiglietto = value;}
        }		
	}
}
