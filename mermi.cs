using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OdevUcak
{
     class mermi
    {
        private int x;
        private int y;
        private int width;
        Image resim;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public mermi(int _x, int _y)
        {
            X = _x; Y = _y;
            resim = Image.FromFile("mermi.png");
            Width = 15;
        }
        public void mermiCizdir(Graphics g)
        {
            g.DrawImage(resim, X, Y, Width, Width);
        }
     }
}
