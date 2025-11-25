using OdevUcak;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OdevUcak
{
    public partial class Form1 : Form
    {
        List <ucak> ucaklar =new List<ucak>();
        List<mermi> mermiler = new List<mermi>();
        savar s =new savar(100, 420);
        Graphics g;
        int sayac = 0;  
        private Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        void cizim()
        {
            g = this.CreateGraphics();
            g.Clear(Color.Black);
            if (ucaklar.Count < 7)
                ucaklar.Add(new ucak(rnd.Next(1, 10) * 40, -40));
            foreach (ucak u in ucaklar)
            {
                u.Y += sayac;
                u.ucakCizdir(g);
                if (u.Y <= 400)
                {
                    timer1.Stop();
                    sayac = 0;
                    MessageBox.Show("Oyun Bitti");
                    g.Clear(Color.Black);


                }
            }
            foreach (mermi m in mermiler)
            {
                m.Y -= sayac;
                m.mermiCizdir(g);
            }
            s.savarCizdir(g);
            for (int i = 0; i < ucaklar.Count; i++)
            {
                for (int j = 0; j < mermiler.Count; j++)
                {
                    if (mermiler[j].X + 15 > ucaklar[i].X && mermiler[j].X < ucaklar[i].X + 40 && mermiler[j].Y < ucaklar[i].Y + 40)
                    {
                        ucaklar.RemoveAt(i);
                        mermiler.RemoveAt(j);
                        break;
                    }
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 1000;
            this.Height = 500;
            ucaklar.Add(new ucak(10, 10));
            ucaklar.Add(new ucak(30, -30));
            ucaklar.Add(new ucak(50, -50));
            ucaklar.Add(new ucak(100, -10));
            ucaklar.Add(new ucak(150, -50));
            ucaklar.Add(new ucak(100, -100));
            timer1.Interval = 1000;
            timer1.Start();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //g = this.CreateGraphics();
            if (e.KeyCode == Keys.Left)
            {
                s.X -= 20;
            }
            if (e.KeyCode == Keys.Right)
            {
                s.X += 20;
            }
            if (e.KeyCode == Keys.Space)
            {
                mermiler.Add(new mermi(s.X + 13, s.Y - 15));
            }
            //cizim();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Enabled = true;
            sayac++;
            if (sayac >= 100)
                timer1.Stop();
            cizim();
        }
    }
}
