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
        public bool vazio = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Exportartxt_MouseClick(object sender, MouseEventArgs e)
        {
            nomes = textBox1.Text + ";" + textBox2.Text + ";" + textBox3.Text + ";" + textBox4.Text;//informações.ToString();
            Char delimiter = ';';
            String[] substrings = nomes.Split(delimiter);
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:/Users/thiago.mattos/Desktop/Test_TXT/InformaçõesDosFuncionários.txt", true))
                {
                    file.WriteLine("////// Funcionario" + numero + " //////");
                    numero++;
                }
            foreach (string substring in substrings)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:/Users/thiago.mattos/Desktop/Test_TXT/InformaçõesDosFuncionários.txt", true))
                {
                    
                    file.WriteLine(substring);
                }
            }
            }
                    else
                    {
                        vazio = true;
                    }

                    if(vazio)
                    {
                         MessageBox.Show("Preencha todos os campos", "ERROR 404");
                         vazio = false;
                    }
                }
            }
}
