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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject("Text pus in Clipboard");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            IDataObject ido = Clipboard.GetDataObject();
            // Graphics g = panel1.CreateGraphics();
            Graphics g = Graphics.FromHwnd(panel1.Handle);
            if (ido != null)
            {
                if (ido.GetDataPresent(DataFormats.Text))
                {
                    string str = (string)ido.GetData(DataFormats.Text);
                    g.DrawString(str, Font, Brushes.Red, 20, 20);
                }
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            listBox1.DoDragDrop(listBox1.SelectedItem, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void textBox3_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.KeyState & 8) == 8 && (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
            {
                e.Effect = DragDropEffects.Move;
            }

        }

        private void textBox3_DragDrop(object sender, DragEventArgs e)
        {
            TextBox cine = (TextBox)sender;
            if (cine != null)
                cine.Text += e.Data.GetData(DataFormats.Text);
            if (e.Effect == DragDropEffects.Move)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

        }
    }
}
