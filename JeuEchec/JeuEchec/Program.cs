using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuEchec
{
    static class Program
    {
        static Form_Jeu jeu;
        
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            jeu = new Form_Jeu();
            jeu.initPlateau();
            Application.EnableVisualStyles();
            Application.Run(jeu);
            //Application.SetCompatibleTextRenderingDefault(false);


        }
    }
}
