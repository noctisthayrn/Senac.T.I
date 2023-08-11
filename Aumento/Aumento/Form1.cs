using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aumento
{
    public partial class Form1 : Form
    {
        // Salario Atual e Novo
        decimal salarioA;
        decimal salarioN;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb2.Text = "";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            salarioA = Convert.ToInt32(tb1.Text);

            if(salarioA >= 5000)
            {
                salarioN = salarioA + salarioA * 10 / 100;
                tb2.Text = salarioN.ToString("C");
            }
            else if(salarioA >= 2000 && salarioA < 5000)
            {
                salarioN = salarioA + salarioA * 20 / 100;
                tb2.Text = salarioN.ToString("C");
            }
            else
            {
                salarioN = salarioA + salarioA * 30 / 100;
                tb2.Text = salarioN.ToString("C");
            }
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            if(tb1.Text == "")
            {
                bt1.Enabled = false;
                tb2.Text = "";
            }
            else
            {
                bt1.Enabled = true;
            }
        }
    }
}
