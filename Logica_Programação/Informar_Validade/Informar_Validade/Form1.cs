using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informar_Validade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCode.Items.Add("Selecione um Código");
            cbCode.Items.Add("01");
            cbCode.Items.Add("02");
            cbCode.Items.Add("03");
            cbCode.Items.Add("04");
            cbCode.Items.Add("05");
            cbCode.Items.Add("06");
            cbCode.Items.Add("07");

            cbCode.SelectedIndex = 0;
            lbResult.Text = "";
        }
        private void btCheck_Click(object sender, EventArgs e)
        {
            switch (cbCode.SelectedIndex)
            {
                case 1:
                    lbResult.Text = "Alimento não-perecível";
                    break;
                case 2:
                    lbResult.Text = "Alimento perecível";
                    break;
                case 3:
                    lbResult.Text = "Bebidas";
                    break;
                case 4:
                    lbResult.Text = "Vestuário";
                    break;
                case 5:
                    lbResult.Text = "Limpeza";
                    break;
                case 6:
                    lbResult.Text = "Higiene Pessoal";
                    break;
                case 7:
                    lbResult.Text = "Eletrodomésticos";
                    break;
                default:
                    cbCode.Focus();
                    break;
            }
        }
    }
}
