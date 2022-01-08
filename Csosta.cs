using System;
using System.Collections.Generic;

namespace Parcheggio
{	
	public class Csosta
	{
		//attributi		
		private string dataIngresso;
		private string oraIngresso;
		private string minutiIngresso;
		private string targaMezzo;
		private string tipo_Veicolo;
		private string tipoAlimentazione;
				 
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
		public string TargaMezzo
        {
            get {return targaMezzo;}
            set { targaMezzo = value;}
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
	}		
}
