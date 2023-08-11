using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preço_Produto
{
    public partial class Form1 : Form
    {
        //Variaveis das caixas de texto
        decimal compra;
        decimal porc;
        decimal venda;

        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bt1.Enabled = false;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            compra = Convert.ToInt32(tb1.Text);
            porc = Convert.ToInt32(tb2.Text);

            venda = compra + compra * porc / 100;
            tb3.Text = venda.ToString("C");
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            if(tb1.Text != "" && tb2.Text != "")
            {
                bt1.Enabled = true;
            }
            else
            {
                bt1.Enabled = false;
            }
        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {
            if (tb1.Text != "" && tb2.Text != "")
            {
                bt1.Enabled = true;
            }
            else
            {
                bt1.Enabled = false;
            }
        }
    }
}
