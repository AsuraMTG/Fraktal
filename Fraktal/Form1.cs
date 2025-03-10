using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fraktal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color katt;
        Color szomszedSzine;
        Bitmap b;
        public int X;
        public int Y;
        public void Joe(Color katt, Color szomszedSzine)
        {
            Math.Abs(katt.R - szomszedSzine.R);
            Math.Abs(katt.G - szomszedSzine.G);
            Math.Abs(katt.B - szomszedSzine.B);
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            katt = b.GetPixel(e.X, e.Y);
            szomszedSzine = b.GetPixel(e.X + 1, e.Y);
            X = e.X;
            Y = e.Y;
            label1.Text = $"RGB: {katt.R}, {katt.G}, {katt.B}";
        }
        private void Form1_Load(object sender, EventArgs e)
        { 
            Bitmap b = Properties.Resources.alap042_000_500_13c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            b.SetPixel(X, Y, color);
            Joe(katt, szomszedSzine);
            pictureBox1.Image = b;
        }
    }
}