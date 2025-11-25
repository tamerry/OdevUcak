using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevUcak
{
    class ucak
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
        public ucak()
        {
            resim = Image.FromFile("ucak.png");
            Width = 40;
        }
        public ucak(int _x, int _y)
        {
            X = _x; Y = _y;
            resim = Image.FromFile("ucak.png");
            Width = 40;
        }
        public void ucakCizdir(Graphics g)
        {
            g.DrawImage(resim, X, Y, Width, Width);
        }

    }
    class GucUcak : ucak
    {
    }
}
