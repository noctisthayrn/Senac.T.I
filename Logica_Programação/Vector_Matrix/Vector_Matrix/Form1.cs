using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector_Matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            libList.Items.Clear();
            libPares.Items.Clear();

            tbMaiorNumero.Enabled = false;
            tbMenorNumero.Enabled = false;
        }

        private void btVector_Click(object sender, EventArgs e)
        {
            libList.Items.Clear();

            int[] numero = new int[10];
            Random aleatorio = new Random();
            
            for(int i = 0; i < numero.Length; i++)
            {
                int numeroAle = aleatorio.Next(0, 200);
                numero[i] = numeroAle;
                libList.Items.Add(numero[i]);
            }
            
            for(int i = 0; i < numero.Length; i++)
            {
                if(numero[i] % 2 == 0)
                {
                    libPares.Items.Add(numero[i]);
                }
            }

            int maior = numero.Max();
            tbMaiorNumero.Text = maior.ToString();

            int menor = numero.Min();
            tbMenorNumero.Text = menor.ToString();
        }

        private void btMatrix_Click(object sender, EventArgs e)
        {
            libList.Items.Clear();

            int[,] numero = new int[4, 4];
            Random aleatorio = new Random();

            for(int i = 0; i < numero.GetLength(0); i++)
            {
                for (int x = 0; x < numero.GetLength(1); x++)
                {
                    int numeroAle = aleatorio.Next(0, 30);
                    numero[i, x] = numeroAle;

                    libList.Items.Add($"[{i}], [{x}] = {numero[i, x]}");

                    if(numero[i,x] > 10)
                    {
                        libPares.Items.Add(numero[i, x]);
                    }
                }
            }

        }
    }
}
