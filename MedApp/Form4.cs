using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedApp
{
    public partial class Form4 : Form
    {
        public int[] vectDiagnostic;

        public Form4()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int ymax = vectDiagnostic.Max();
            float rapScalare = panel1.Height / ymax;
            Brush[] culori = new Brush[]
            {
                Brushes.Blue,Brushes.Yellow,Brushes.Red,Brushes.Violet,Brushes.Green,
                Brushes.Gray,Brushes.Pink,Brushes.Orange,Brushes.Lavender,Brushes.Bisque
            };
            int lat = panel1.Width / 10;
            int vb = panel1.Bottom;
            for (int i = 0; i < 10; i++)
            {
                g.FillRectangle(culori[i % culori.Length], i * lat, vb - vectDiagnostic[i] * rapScalare, lat, vectDiagnostic[i] * rapScalare);
            }
        }
    }
}
