using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Представьте, что у вас на форме есть прямоугольник,
 * границы которого на 100 пикселей отстоят от границ 
 * рабочей области формы. Необходимо создать следующие 
 * обработчики:
■ Обработчик нажатия левой кнопки мыши, который выводит сообщение 
о том, где находится текущая точка: внутри прямоугольника, снаружи,
на границе прямоугольника.Если при нажатии левой кнопки 
мыши была нажата кнопка Control (Ctrl), то приложение должно закрываться;

Обработчик нажатия правой кнопки мыши, который выводит в заголовок 
окна информацию о размере клиентской (рабочей) области окна в 
виде: Ширина = x, Высота = y, где x и y – соответствующие параметры вышего окна;

■ Обработчик перемещения указателя мыши в пределах рабочей 
области, который должен выводить в заголовок окна
текущие координаты мыши x и y.
 
 
 */

namespace Task3
{
    public partial class Form1 : Form
    {
        bool tempControl ;
        int form1Weight;
        int form1Height;
        public Form1()
        {
            InitializeComponent();
            this.Text = "win Form";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Width = 900;
            this.Height = 600;
            form1Weight = this.Width;
            form1Height = this.Height;
            label1.Width = this.Width-100;
            label1.Height = this.Height-100;
            label1.Location = new Point(10, 10);
           
        }



        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            Form frm = (Form)sender;
            frm.Text = String.Format("x = {0}   y = {1} ", e.X, e.Y);

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left && tempControl == true) { Application.Exit(); }
            else if(e.Button == MouseButtons.Left) MessageBox.Show("Outside rectangle");

            if (e.Button == MouseButtons.Right) MessageBox.Show($"ширина  = {form1Weight} , высота = {form1Height}");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
           if (e.KeyCode == Keys.ControlKey) { tempControl = true; } 
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.ControlKey) { tempControl = false; }
        }

       

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            Label l = (Label)sender;
            l.Text = String.Format($"X = {e.X} , y = {e.Y}"); 
            
          
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
           if(e.Button == MouseButtons.Left) MessageBox.Show("Inside rectangle");
            if (e.Button == MouseButtons.Right) MessageBox.Show($"ширина рабочей области = {label1.Height} \n высота рабочей области = {label1.Width}");
        }
    }
}
