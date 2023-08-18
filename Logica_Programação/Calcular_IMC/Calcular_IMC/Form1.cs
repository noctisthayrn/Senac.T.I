using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btCal.Enabled = false;
            tbIMC.Enabled = false;
            lbMessage.Text = "";
        }

        private void tbKg_TextChanged(object sender, EventArgs e)
        {
            if(tbKg.Text != "" && tbHight.Text != "")
            {
                btCal.Enabled = true;
            }
            else
            {
                btCal.Enabled = false;
            }
        }

        private void tbHight_TextChanged(object sender, EventArgs e)
        {
            if (tbKg.Text != "" && tbHight.Text != "")
            {
                btCal.Enabled = true;
            }
            else
            {
                btCal.Enabled = false;
            }
        }

        private void btCal_Click(object sender, EventArgs e)
        {
            //Criar as varias para calcular o IMC
            double imc, kg, hight;
            kg = Double.Parse(tbKg.Text);
            hight = Double.Parse(tbHight.Text);
            imc = kg / (hight * hight);

            if(imc >= 40)
            {
                tbIMC.Text = imc.ToString();
                lbMessage.Text = "Obesidade III (mórbida";
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                tbIMC.Text = imc.ToString();
                lbMessage.Text = "Obesidade II (severa)";
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                tbIMC.Text = imc.ToString();
                lbMessage.Text = "Obesidade grau I";
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                tbIMC.Text = imc.ToString();
                lbMessage.Text = "Levemente acima do peso";
            }
            else if (imc >= 18.6 && imc <= 24.9)
            {
                tbIMC.Text = imc.ToString();
                lbMessage.Text = "Peso ideal";
            }
            else
            {
                tbIMC.Text = imc.ToString();
                lbMessage.Text = "Abaixo do Peso";
            }
        }
    }
}
