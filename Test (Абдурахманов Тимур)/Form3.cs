using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test__Абдурахманов_Тимур_
{
    public partial class Form3 : Form
    {
        int mark; string fullName;
        public Form3(int mark, string fullName)
        {
            InitializeComponent();
            this.mark = mark;
            this.fullName = fullName;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "Количество баллов: " + mark.ToString();
            int n = 2;
            if (mark >= 0 && mark <= 4) { n = 2; label2.Text += " 2"; }
            if (mark >= 5 && mark <= 6){ n = 3; label2.Text += " 3"; }
            if (mark >= 7 && mark <= 8) { n = 4; label2.Text += " 4"; }
            if (mark >= 9 && mark <= 10) { n = 5; label2.Text += " 5"; }
            label3.Text = "Ученик: " + fullName;

            richTextBox1.LoadFile("log.rtf");
            richTextBox1.Text += $"Тест [{DateTime.Now.ToString("dd.MM.yy HH.mm.ss")}]\nФИО: {fullName}\nКоличество баллов: {mark}\nОценка: {n}\n\n";
            richTextBox1.SaveFile("log.rtf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
