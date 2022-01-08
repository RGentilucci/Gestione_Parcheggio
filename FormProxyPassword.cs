using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Parcheggio
{	
	public partial class FormProxyPassword : Form
	{		
		//attributi
		private string password;
		
		//costruttore
		public FormProxyPassword()
		{			
			InitializeComponent();			
		}
		
		//metodi		
		//acquisizione password di sistema previa lettura da file di archivio password
		void FormProxyPasswordLoad(object sender, EventArgs e)
		{
			StreamReader sr 			= new StreamReader("Password.txt");
			password					= (sr.ReadLine());
			txtPassword.PasswordChar 	= '*';
			txtPassword.MaxLength 		= 10;          
        	sr.Close();
		}		
		//verifica della password ed inoltro della richiesta alla FormGestione con il click del btnOK
		void BtnOKClick(object sender, EventArgs e)
		{
		if (password == txtPassword.Text)
			{
			FormGestione fg = new FormGestione();
			fg.Show();
			Close();
			}
			else
			{
				MessageBox.Show("Password errata: inserire di nuovo la password !!"); 
				txtPassword.Clear();
			}
		}	
	}
}
