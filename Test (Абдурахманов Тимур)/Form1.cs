using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test__Абдурахманов_Тимур_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string fullName;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Вы не ввели все данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                if(MessageBox.Show("Вы уверены в веденных данных? В случаи ошибки придется пройти тест занаво!", "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    fullName = textBox1.Text.ToString();
                    if (fullName.Contains("1") || fullName.Contains("2") || fullName.Contains("3") || fullName.Contains("4") || fullName.Contains("5") || fullName.Contains("6")
                        || fullName.Contains("7") || fullName.Contains("8") || fullName.Contains("9") || fullName.Contains("0"))
                    {
                        MessageBox.Show("В ФИО не может быть цифры!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        fullName += " «" + comboBox1.Text.ToString() + "-" + comboBox2.Text.ToString() + "»";
                        Hide();
                        Form2 form2 = new Form2(fullName);
                        form2.ShowDialog();
                    }
                    try
                    {
                        Show();
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 form2 = new Form5();
            form2.ShowDialog();
            Show();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 form2 = new Form4();
            form2.ShowDialog();
            Show();
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
