using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuEchec
{
    class Case : Button
    {
          
        public Case(string name, System.Drawing.Bitmap bitmap,string color)// string nom , color , image,position
        {
           
            this.Name = name;
            this.Size = new System.Drawing.Size(50,50);
            this.Margin = new Padding(0,0,0,1);
            this.Image = new System.Drawing.Bitmap(bitmap);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);
        }

    }
}
