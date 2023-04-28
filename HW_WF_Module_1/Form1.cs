using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace HW_WF_Module_1
{/*Вывести на экран свое (краткое!!!) резюме с помощью последовательности MessageBox’ов (числом не менее трех). Причем на заголовке
последнего должно отобразиться среднее число символов на странице
(общее количество символов в резюме / количество MessageBox’ов). */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        string [] Resume1 = {"Матвейчук Сергей Михайлович\nУкраина\nг.Одесса",
        "Work Experience - Dolphin Director and Sea Cat Tamer 2012-2015 y." +
                            "\nTreasure thief and pirate chief assistant  2016-2019" +
                            "\nBurrito taster in northern Umbayus tribe  2020-now",
        "I plan to study and become a programmer" };
        



        private void button1_Click(object sender, EventArgs e)
        {
            
            int temp = (Resume1[0].Length+Resume1[1].Length+Resume1[2].Length)/3;
            
            MessageBox.Show(Resume1[0], "Titul");
            MessageBox.Show(Resume1[1], "Titul2");
            MessageBox.Show(Resume1[2], temp.ToString());
        }
    }
}
