using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            libResult.Items.Clear();
            tbMedium.Enabled = false;
            tbSoma.Enabled = false;
        }
        private void btFor_Click(object sender, EventArgs e)
        {
            libResult.Items.Clear();

            libResult.Items.Add("For Select");

            //int value = 7;
            //for(int power = 0; power <= 30; power++)
            //{
            //    libResult.Items.Add(Math.Pow(value, power));
            //}
            for(int i = 50; i >= 1; i--)
            {
                libResult.Items.Add(i);
            }
        }

        private void btWhile_Click(object sender, EventArgs e)
        {
            libResult.Items.Clear();

            int n = 0;
            libResult.Items.Add("While Select");

            while(n <= 100)
            {
                libResult.Items.Add(n);
                n++;
            }
        }

        private void btDoWhile_Click(object sender, EventArgs e)
        {
            libResult.Items.Clear();

            int n = 0;
            libResult.Items.Add("Do While Select");

            do
            {
                libResult.Items.Add(n);
                n+=5;
            }
            while (n <= 100);
        }

        private void btImpar_Click(object sender, EventArgs e)
        {
            libResult.Items.Clear();
            libResult.Items.Add("Numeros Impares");

            for (int i = 1; i <= 50; i++)
            {
                if(i % 2 == 0)
                {

                }
                else
                {
                    libResult.Items.Add(i);
                }
            }
        }

        private void btSoma_Click(object sender, EventArgs e)
        {
            libResult.Items.Clear();

            int soma = 0;
            int n = 1;

            while (n <= 50)
            {
                libResult.Items.Add(n);
                soma = soma + n;
                tbSoma.Text = soma.ToString();
                n++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            libResult.Items.Clear();

            int soma = 0;
            int n = 1;

            while (n <= 50)
            {
                libResult.Items.Add(n);
                soma = soma + n;
                tbSoma.Text = soma.ToString();
                n++;
            }
            soma = soma / 50;
            tbMedium.Text = soma.ToString();
        }
    }
}
