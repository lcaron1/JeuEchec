using JeuEchec.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuEchec
{
    class Fou : Piece
    {
        private Image image;
        public Image Image { get => image; set => image = value; }
        public Fou(string color) : base(color) {
            if (color == "black")
            {
                Image image = new Bitmap(Resources.fouN);

            }
            else
            {
                Image image = new Bitmap(Resources.fouB);
            }
        }

       
    }
}
