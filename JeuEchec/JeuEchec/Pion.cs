using JeuEchec.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuEchec
{
    class Pion : Piece
    {
        private Image image;
        public Image Image { get => image; set => image = value; }

        public Pion(string color) : base(color)
        {
            if (color == "black")
            {
                Image image = new Bitmap(Resources.pionN);

            }
            else
            {
                Image image = new Bitmap(Resources.pionB);
            }
        }

        
    }
}
