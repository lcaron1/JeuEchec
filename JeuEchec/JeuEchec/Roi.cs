using JeuEchec.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuEchec
{
    class Roi : Piece
    {
     private Image image;
        
        public Image Image { get => image; set => image = value; }
        public Roi(string color) : base(color) {
            if(color == "black")
            {
                Image image = new Bitmap(Resources.roiN);
           
            }
            else
            {
                Image image = new Bitmap(Resources.roiB);
            }
        }

        
    }
}
