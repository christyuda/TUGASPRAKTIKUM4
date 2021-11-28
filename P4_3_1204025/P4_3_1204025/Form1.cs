using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace P4_3_1204025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtHuruf_Leave(object sender, EventArgs e)
        {
            if (TxtHuruf.Text == "")
            {
                epWarning.SetError(TxtHuruf, "Textbox Huruf tidak boleh kosong");
                epWrong.SetError(TxtHuruf, "");
                epCorrect.SetError(TxtHuruf, "Betul!");
            }
            else
            {
                if ((TxtHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(TxtHuruf, "");
                    epWrong.SetError(TxtHuruf, "");
                    epCorrect.SetError(TxtHuruf, "Betul!");
                }
                else
                {
                    epWrong.SetError(TxtHuruf, "inputan hanya boleh huruf!");
                    epWarning.SetError(TxtHuruf, "");
                    epCorrect.SetError(TxtHuruf, "");
                }
            }
        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if ((txtAngka.Text).All(Char.IsLetter))
            {
                epWarning.SetError(txtAngka, "");
                epWrong.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "Betul!");
            }
            else
            {
                epWrong.SetError(txtAngka, "");
                epWarning.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "inputan hanya boleh Angka!");
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if(Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epWarning.SetError(txtEmail, "");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "Betul!");
            }
            else
            {
                epWrong.SetError(txtEmail, "Format email salah !\nContoh: a@b.c");
                epWarning.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if ((textBox4.Text).All(Char.IsNumber))
            {
                if (textBox4.Text == "")
                {
                    epWarning.SetError(textBox4, "Angka 2 Belum terisi");
                }

                else
                {
                    epCorrect.SetError(textBox4, "Angka 2 Terisi");
                }
            }

            else if (textBox4.Text == "")
            {
                epWarning.SetError(textBox4, "Textbox Huruf tidak boleh kosong");

            }

            else
            {
                epWrong.SetError(textBox4, "inputan hanya boleh Angka!");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if ((textBox5.Text).All(Char.IsNumber))
            {
                int angka1 = int.Parse(textBox4.Text);
                int angka2 = int.Parse(textBox5.Text);
                if (angka1 > angka2)
                {
                    epCorrect.SetError(textBox5, "Angka 1 lebih besar dari angka 2 ");
                }
            }

            else if ((textBox5.Text == ""))
            {
                epWarning.SetError(textBox5, "Textbox Huruf tidak boleh kosong");

            }

            else
            {
                epWrong.SetError(textBox5, "inputan hanya boleh Angka!");
            }
        }
    }
}
