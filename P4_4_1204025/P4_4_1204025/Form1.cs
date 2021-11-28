using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_4_1204025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

                if (textBox1.Text == ""  )
            {
                epWarning.SetError(textBox1, "ini tidak boleh kosong");
                epWrong.SetError(textBox1, "");
                epCorrect.SetError(textBox1, "");
            }
            else
            {
                if (textBox1.Text == textBox1.Text.ToUpper() && (textBox2.Text.Length < 10) )
                {
                    epWarning.SetError(textBox1, "");
                    epWrong.SetError(textBox1, "");
                    epCorrect.SetError(textBox1, "betul");
                }
                else
                {
                    epWrong.SetError(textBox1, "Hanya huruf besar dan maksimal 10 huruf");
                    epWarning.SetError(textBox1, "");
                    epCorrect.SetError(textBox1, "");
                }
            }
            

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

            if ((textBox2.Text == "") )
            {
                epWarning.SetError(textBox2, "ini tidak boleh kosong");
                epWrong.SetError(textBox2, "");
                epCorrect.SetError(textBox2, "");
            }
            else
            {
                if (textBox2.Text == textBox2.Text.ToLower() && (textBox2.Text.Length > 6 )) 
                    
                {
                    
                    epWarning.SetError(textBox2, "");
                    epWrong.SetError(textBox2, "");
                    epCorrect.SetError(textBox2, "betul ");
                }
                else 
                {
                    epWrong.SetError(textBox2, "hanya boleh huruf kecil dan minimal 6 kata");
                    epWarning.SetError(textBox2, "");
                    epCorrect.SetError(textBox2, "");
                }
            }


            
        }

        private void tbHuruf_Leave(object sender, EventArgs e)
        {
            if (tbHuruf.Text == "")
            {
                epWarning.SetError(tbHuruf, "Textbox Huruf tidak boleh kosong");
                epWrong.SetError(tbHuruf, "");
                epCorrect.SetError(tbHuruf, "Betul!");
            }
            else
            {
                if ((tbHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(tbHuruf, "");
                    epWrong.SetError(tbHuruf, "");
                    epCorrect.SetError(tbHuruf, "Betul!");
                }
                else
                {
                    epWrong.SetError(tbHuruf, "inputan hanya boleh huruf!");
                    epWarning.SetError(tbHuruf, "");
                    epCorrect.SetError(tbHuruf, "");
                }
            }
        }

        private void tbAngka_Leave(object sender, EventArgs e)
        {
            if (tbAngka.Text == "" )
            {
                epWarning.SetError(tbAngka, "Usia tidak boleh kosong");
                epWrong.SetError(tbAngka, "");
                epCorrect.SetError(tbAngka, "");
            }
            else
            {
                if ((tbAngka.Text).All(char.IsDigit))
                {
                    epWarning.SetError(tbAngka, "");
                    epWrong.SetError(tbAngka, "");
                    epCorrect.SetError(tbAngka, "Betul!");
                }
                else
                {
                    epWrong.SetError(tbAngka, "inputan hanya boleh Angka!");
                    epWarning.SetError(tbAngka, "");
                    epCorrect.SetError(tbAngka, "");
                }
            }

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                epWarning.SetError(tbEmail, "email tidak boleh kosong");
                epWrong.SetError(tbEmail, "");
                epCorrect.SetError(tbEmail, "");
            }
            else
            {
                if (Regex.IsMatch(tbEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(tbEmail, "");
                    epWrong.SetError(tbEmail, "");
                    epCorrect.SetError(tbEmail, "Betul!");
                }
                else
                {
                    epWrong.SetError(tbEmail, "Format email salah !\nContoh: a@b.c");
                    epWarning.SetError(tbEmail, "");
                    epCorrect.SetError(tbEmail, "");
                }
            }
        }

        private void tbAngka1_Leave(object sender, EventArgs e)
        {
            if ((tbAngka1.Text).All(Char.IsNumber))
            {
                if (tbAngka1.Text == "")
                {
                    epWarning.SetError(tbAngka1, "Angka 2 Belum terisi");
                }

                else
                {
                    epCorrect.SetError(tbAngka1, "Angka 2 Terisi");
                }
            }

            else if (tbAngka1.Text == "")
            {
                epWarning.SetError(tbAngka1, "Textbox Huruf tidak boleh kosong");

            }

            else
            {
                epWrong.SetError(tbAngka1, "inputan hanya boleh Angka!");
            }

        }

        private void tbAngka2_Leave(object sender, EventArgs e)
        {
            if ((tbAngka2.Text).All(Char.IsNumber))
            {
                int angka1 = int.Parse(tbAngka1.Text);
                int angka2 = int.Parse(tbAngka2.Text);
                if (angka1 > angka2)
                {
                    epCorrect.SetError(tbAngka2, "Angka 1 lebih besar dari angka 2 ");
                }
            }

            else if ((tbAngka2.Text == ""))
            {
                epWarning.SetError(tbAngka2, "Textbox Huruf tidak boleh kosong");

            }

            else
            {
                epWrong.SetError(tbAngka2, "inputan hanya boleh Angka!");
            }

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("\nNama : " + tbHuruf.Text + "Usia : " + tbAngka.Text  + "\nEmail : " + tbEmail.Text  + "\nPassword dalam UPPERCASE : " + textBox1.Text + "\nPassword dalam lowercase : " + textBox2.Text + "\nPerbandingan : " + tbAngka1.Text + " " + tbAngka2.Text);

            }
        }
    }
}
