using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_TXT
{
    public partial class Form1 : Form
    {
        public string nomes;
        public int numero = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Exportartxt_MouseClick(object sender, MouseEventArgs e)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:/Users/thiago.mattos/Desktop/Test_TXT/InformaçõesDosFuncionários.txt", true))
           {
               file.WriteLine("////// Funcionario" + numero + " //////");
              numero++;
           }
            nomes = textBox1.Text + ";" + textBox2.Text + ";" + textBox3.Text + ";" + textBox4.Text;//informações.ToString();
            Char delimiter = ';';
            String[] substrings = nomes.Split(delimiter);
            foreach (string substring in substrings)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:/Users/thiago.mattos/Desktop/Test_TXT/InformaçõesDosFuncionários.txt", true))
                {
                    if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "") {
                    file.WriteLine(substring);
                    /*if (textBox1.Text == "")
                    {
                        file.WriteLine("--------");
                    }
                    else if(textBox1.Text != "")
                    {
                        file.WriteLine(substring);
                    }
                    if (textBox2.Text == "")
                    {
                        file.WriteLine("--------");
                    }
                    else if (textBox2.Tsext != "")
                    {
                        file.WriteLine(substring);
                    }*/}
                    else
                    {
                        MessageBox.Show("Preencha todos os campos", "ERROR 404");
                    }
                }
            }
        }
    }
}
