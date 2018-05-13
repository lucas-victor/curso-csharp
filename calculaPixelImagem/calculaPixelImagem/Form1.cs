using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculaPixelImagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1 = 0;
            int valor2 = 0;

            int[] dezenas = new int[10];
            string[] letras = new string[10];
            letras[0] = "maria0";

            int[] teste = new int[100];
            
            teste[0] = 1;

            double num1, num2;

            OpenFileDialog file = new OpenFileDialog();

            string nome = "";
            long cpf = 07703402536;
            if (nome == cpf.ToString())
            {
                teste
                    
                    
                    }

            for (int i = 0; i <= dezenas.Length; i++)
            {
                dezenas[i] = i;

                if (i < 50)
                {
                    MessageBox.Show("texto, voce tá vendo o valor do i = " + i.ToString());
                }

            }


            


        }
    }
}
