using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_case_Mes
{
    public partial class Form1 : Form
    {
        string[] nomeMes = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btVerificar_Click(object sender, EventArgs e)
        {
            switch (cbMeses.SelectedItem)
            {
                case "Janeiro":
                case "Março":
                case "Maio":
                case "Julho":
                case "Agosto":
                case "Outubro":
                case "Dezembro":
                    lbResultado.Text = "O mês selecionado possui 31 dias";
                    break;
                case "Fevereiro":
                    lbResultado.Text = "O mês selecionado possui 28 dias ou 29 dias";
                    break;
                default:
                    lbResultado.Text = "O mês selecionado possui 30 dias";
                    break;
            }
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

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cbMeses.Items.AddRange(nomeMes);
            btVerificar.Enabled = false;
            lbResultado.Text = "";
        }
    }
}
