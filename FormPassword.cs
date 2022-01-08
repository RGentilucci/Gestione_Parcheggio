using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Parcheggio
{	
	public partial class FormPassword : Form
	{		
		//attributi
		//variabile riferimento per l'implementazione del pattern singleton
        private static FormPassword instance = null;
		
        //costruttore
		public FormPassword()
		{			
			InitializeComponent();			
		}
		
		//metodi
		//Implementazione del pattern singleton
        public static FormPassword Instance()
        {
        	if (instance == null)
        		instance = new FormPassword();
        	return instance;        
        }        
		//caricamento della FormPassword
		void FormPassword_Load(object sender, EventArgs e)
		{
			txtNuovaPassword.PasswordChar 	= '*';
			txtNuovaPassword.MaxLength 		= 10;	
		}	
		//acquisizione della nuova password e registrazione nel file di archivio
		void BtnPasswordClick(object sender, EventArgs e)
		{
			if (txtNuovaPassword.Text.Length != 0)
			{
				StreamWriter sw = new StreamWriter("Password.txt");
            	sw.WriteLine(txtNuovaPassword.Text);
            	sw.Close();					
            	Close();
			}
			else
			{
				MessageBox.Show("Password errata: inserire almeno un carattere !!"); 
				txtNuovaPassword.Clear();		
			}			
		}				
	}
}
