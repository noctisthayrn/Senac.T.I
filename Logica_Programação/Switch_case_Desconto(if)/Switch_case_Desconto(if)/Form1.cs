using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_case_Desconto_if_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbValorFinal.Enabled = false;
            btVerificar.Enabled = false;
            cbDesconto.Items.Add("Selecione");
            cbDesconto.Items.Add("Dinheiro");
            cbDesconto.Items.Add("Pix");
            cbDesconto.Items.Add("Cartão de Débito");
            cbDesconto.Items.Add("Cartão de Crédito");
            cbDesconto.SelectedIndex = 0;
        }

        private void tbPreco_TextChanged(object sender, EventArgs e)
        {
            if (cbDesconto.SelectedIndex == 0 && tbPreco.Text != "")
            {
                btVerificar.Enabled = false;
            }
            else
            {
                btVerificar.Enabled = true;
            }
        }

        private void cbDesconto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDesconto.SelectedIndex == 0 && tbPreco.Text != "")
            {
                btVerificar.Enabled = false;
            }
            else
            {
                btVerificar.Enabled = true;
            }
        }

        private void btVerificar_Click(object sender, EventArgs e)
        {
            decimal valor = Convert.ToInt32(tbPreco.Text);
            if(cbDesconto.SelectedIndex == 1 | cbDesconto.SelectedIndex == 2)
            {
                valor = valor - valor * 10 / 100;
                tbValorFinal.Text = valor.ToString("n2");
            }
            else if(cbDesconto.SelectedIndex == 3)
            {
                valor = valor - valor * 5 / 100;
                tbValorFinal.Text = valor.ToString("n2");
            }
            else
            {
                tbValorFinal.Text = valor.ToString("n2");
            }
        }
    }
}
