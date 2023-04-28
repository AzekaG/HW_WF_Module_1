using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        int temp = 0;
        static int count = 0;
        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            temp = rnd.Next(0, 10);
            this.Text = "Угадай число";
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            ++count;
            if (temp == int.Parse(textBox1.Text))
            { MessageBox.Show($"Поздравляю. Вы угадали число с  {count} попытки!!! "); Application.Exit(); }

            else MessageBox.Show("Увы , пробуйте еще!");
            textBox1.Clear();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (char)Keys.Enter)
            {
                button1_Click(button1, null);
            }
        }
    }
}
