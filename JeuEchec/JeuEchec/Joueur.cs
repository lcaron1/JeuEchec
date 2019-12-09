using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuEchec
{
    class Joueur
    {
        private string color;
        private string nom;

        public string Nom { get => nom; set => nom = value; }

        public Joueur(string color,string nom)
        {
            this.nom = nom;
            this.color = color;            
        }
    }
}
