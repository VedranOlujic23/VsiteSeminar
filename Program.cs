using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Text;



namespace VsiteSeminar
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Ping
        ///Napraviti GUI program koji će u zadanim vremenskim intervalima
        ///provjeravati dostupnost neke IP adrese(slanjem PING upita) te
        ///prikazivati vrijeme odziva za svaki upit.Program treba omogućiti
        ///zadavanje IP adrese i duljine intervala između pojedinih upita u
        ///sekundama.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());



        }
    }



}
