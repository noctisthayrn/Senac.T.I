using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_case_Mes_if_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbMeses.Items.Add("Janeiro");
            cbMeses.Items.Add("Fevereiro");
            cbMeses.Items.Add("Março");
            cbMeses.Items.Add("Abril");
            cbMeses.Items.Add("Maio");
            cbMeses.Items.Add("Junho");
            cbMeses.Items.Add("Julho");
            cbMeses.Items.Add("Agosto");
            cbMeses.Items.Add("Setembro");
            cbMeses.Items.Add("Outubro");
            cbMeses.Items.Add("Novembro");
            cbMeses.Items.Add("Dezembro");
            btVerificar.Enabled = false;
            lbResultado.Text = "";
        }

        private void cbMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMeses.SelectedIndex.Equals(-1))
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
            if (cbMeses.SelectedIndex == 0 | cbMeses.SelectedIndex == 2 | cbMeses.SelectedIndex == 4 | cbMeses.SelectedIndex == 6 | cbMeses.SelectedIndex == 7 | cbMeses.SelectedIndex == 9 | cbMeses.SelectedIndex == 11)
            {
                lbResultado.Text = "O mês selecionado possui 31 dias";
            }
            else if (cbMeses.SelectedIndex == 1)
            {
                lbResultado.Text = "O mês selecionado possui 28 dias ou 29 dias";
            }
            else
            {
                lbResultado.Text = "O mês selecionado possui 30 dias";
            }
        }
    }
}
