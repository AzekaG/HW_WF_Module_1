using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        bool tempControl;
        public Form1()
        {
            InitializeComponent();
            this.Text = "win Form";
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 400);
            this.Width = 900;
            this.Height = 600;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            Form frm = (Form)sender;
            frm.Text = String.Format("x = {0}   y = {1} ", e.X, e.Y);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Form frm = (Form)(sender);
            if (e.Button == MouseButtons.Left && tempControl == true) { Application.Exit(); }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Form frm = (Form)(sender);
            if (e.KeyCode == Keys.Control) { tempControl = true; }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Form frm = (Form)(sender);
            if (e.KeyCode != Keys.Control) { tempControl = false; }
        }

      
    }
}
