using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test__Абдурахманов_Тимур_
{
    public partial class Form2 : Form
    {
        string fullName;
        public Form2(string fullName)
        {
            this.fullName = fullName;
            InitializeComponent();
        }



        string[] masVop = new string[1024];

        private void Form2_Load(object sender, EventArgs e)
        {

            label1.Text = fullName;
            StreamReader sr = new StreamReader("test.txt");
            masVop[0] = sr.ReadLine();
            int i = 0;
            while (masVop[i] != null)
            {
                i++;
                //Read the next line
                masVop[i]= sr.ReadLine();
            }
            //close the file
            sr.Close();


            groupBox1.Text = masVop[0];
            radioButton1.Text = masVop[1];
            radioButton2.Text = masVop[2];
            radioButton3.Text = masVop[3];
            radioButton4.Text = masVop[4];
        }


        int mark, i = 5;
        bool v1 = true, v2 = false, v3 = false, v4 = false, v5 = false, v6 = false
            ,v7 = false, v8 = false, v9 = false, v10 = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (v1)
            {
                if(radioButton3.Checked) mark++;
                v1 = false;
                v2 = true;
            }
            else if (v2)
            {
                v2 = false;
                if (radioButton2.Checked) mark++;
                v3 = true;
            }
            else if (v3)
            {
                v3 = false;
                if (radioButton1.Checked) mark++;
                v4 = true;
            }

            else if (v4)
            {
                v4 = false;
                if (radioButton3.Checked) mark++;
                v5 = true;
            }
            else if (v5)
            {
                v5 = false;
                if (radioButton1.Checked) mark++;
                v6 = true;
            }
            else if (v6)
            {
                v6 = false;
                if (radioButton3.Checked) mark++;
                v7 = true;
            }
            else if (v7)
            {
                v7 = false;
                if (radioButton1.Checked) mark++;
                v8 = true;
            }
            else if (v8)
            {
                v8 = false;
                if (radioButton3.Checked) mark++;
                v9 = true;
            }
            else if (v9)
            {
                v9 = false;
                if (radioButton4.Checked) mark++;
                v10 = true;
            }
            else if (v10)
            {
                if (radioButton3.Checked) mark++;
            }


            if (i < 50)
            {
                groupBox1.Text = masVop[i];
                i++;
                radioButton1.Text = masVop[i];
                i++;
                radioButton2.Text = masVop[i];
                i++;
                radioButton3.Text = masVop[i];
                i++;
                radioButton4.Text = masVop[i];
                i++;
            }
            else
            {
                Form3 form3 = new Form3(mark, fullName);
                Hide();
                form3.ShowDialog();
                Close();
            }
        }
    }
}
