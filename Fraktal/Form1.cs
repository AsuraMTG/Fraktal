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
        Bitmap b;
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            katt = b.GetPixel(e.X, e.Y);

            label1.Text = $"RGB: {katt.R}, {katt.G}, {katt.B}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            b = (Bitmap)Image.FromFile("alap042_000_500_13c.bmp");
        }
    }
}
