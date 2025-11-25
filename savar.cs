using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevUcak
{
     class savar
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
        public savar()
        {
            resim = Image.FromFile("savar.png");
            Width = 40;
        }
        public savar(int _x, int _y)
        {
            X = _x; Y = _y;
            resim = Image.FromFile("savar.png");
            Width = 40;
        }
        public void savarCizdir(Graphics g)
        {
            g.DrawImage(resim, X, Y, Width, Width);
        }
    }
}
