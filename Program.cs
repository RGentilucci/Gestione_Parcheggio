using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Parcheggio;

namespace Gestione_Parcheggio
{
    static class Program
    {
        
    	//Punto di ingresso principale dell'applicazione.
        static void Main() 
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormMain fm = FormMain.Instance();
            Application.Run(fm);
        }
    }
}
