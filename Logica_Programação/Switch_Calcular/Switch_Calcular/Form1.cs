using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Calcular
{
    public partial class Form1 : Form
    {
        string[] desconto = {"Selecionado", "Dinheiro", "Pix", "Cartão de Débito", "Cartão de Crédito" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbValorFinal.Enabled = false;
            btVerificar.Enabled = false;
            cbDesconto.Items.AddRange(desconto);
            cbDesconto.SelectedIndex = 0;
        }

        private void btVerificar_Click(object sender, EventArgs e)
        {
            decimal valor = Convert.ToInt32(tbPreco.Text);

            switch (cbDesconto.SelectedItem)
            {
                case "Dinheiro":
                case "Pix":
                    valor = valor - valor * 10 / 100;
                    tbValorFinal.Text = valor.ToString("n2");
                    break;

                case "Cartão de Débito":
                    valor = valor - valor * 20 / 100;
                    tbValorFinal.Text = valor.ToString("n2");
                    break;

                case "Cartão de Crédito":
                    tbValorFinal.Text = valor.ToString("n2");
                    break;
            }
        }

        //Ativa o Botão Verificar só se Valor for informado e forma de pagamento selecionado
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
    }
}
