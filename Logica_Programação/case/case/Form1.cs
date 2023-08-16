using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @case
{
    public partial class Form1 : Form
    {
        int dia = 0;
        string[] combo = { "01", "02", "03", "04", "05", "06", "07" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb1.Items.AddRange(combo);
        }

        //Verificar ComboBox
        private void bt1_Click(object sender, EventArgs e)
        {
            dia = Convert.ToInt32(cb1.SelectedItem);
            if (dia == 1)
            {
                tb3.Text = dia.ToString("Domingo");
            }
            else if (dia == 2)
            {
                tb3.Text = dia.ToString("Segunda-feira");
            }
            else if (dia == 3)
            {
                tb3.Text = dia.ToString("Terça-feira");
            }
            else if (dia == 4)
            {
                tb3.Text = dia.ToString("Quarta-feira");
            }
            else if (dia == 5)
            {
                tb3.Text = dia.ToString("Quinta-feira");
            }
            else if (dia == 6)
            {
                tb3.Text = dia.ToString("Sexta-feira");
            }
            else
            {
                tb3.Text = dia.ToString("Sábado");
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            dia = Convert.ToInt32(cb1.SelectedItem);
            switch (dia)
            {
                case 1:
                    tb3.Text = dia.ToString("Domingo");
                    break;
                case 2:
                    tb3.Text = dia.ToString("Segunda-feria");
                    break;
                case 3:
                    tb3.Text = dia.ToString("Terça-feira");
                    break;
                case 4:
                    tb3.Text = dia.ToString("Quarta-feira");
                    break;
                case 5:
                    tb3.Text = dia.ToString("Quinta-feira");
                    break;
                case 6:
                    tb3.Text = dia.ToString("Sexta-feira");
                    break;
                case 7:
                    tb3.Text = dia.ToString("Sábado");
                    break;
            }
        }

        //Verificar TextBom

        private void bt3_Click(object sender, EventArgs e)
        {
            dia = Convert.ToInt32(tb1.Text);
            if (dia == 1)
            {
                tb2.Text = dia.ToString("Domingo");
            }
            else if (dia == 2)
            {
                tb2.Text = dia.ToString("Segunda-feira");
            }
            else if (dia == 3)
            {
                tb2.Text = dia.ToString("Terça-feira");
            }
            else if (dia == 4)
            {
                tb2.Text = dia.ToString("Quarta-feira");
            }
            else if (dia == 5)
            {
                tb2.Text = dia.ToString("Quinta-feira");
            }
            else if (dia == 6)
            {
                tb2.Text = dia.ToString("Sexta-feira");
            }
            else
            {
                tb2.Text = dia.ToString("Sábado");
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            dia = Convert.ToInt32(tb1.Text);
            switch (dia)
            {
                case 1:
                    tb2.Text = dia.ToString("Domingo");
                    break;
                case 2:
                    tb2.Text = dia.ToString("Segunda-feria");
                    break;
                case 3:
                    tb2.Text = dia.ToString("Terça-feira");
                    break;
                case 4:
                    tb2.Text = dia.ToString("Quarta-feira");
                    break;
                case 5:
                    tb2.Text = dia.ToString("Quinta-feira");
                    break;
                case 6:
                    tb2.Text = dia.ToString("Sexta-feira");
                    break;
                case 7:
                    tb2.Text = dia.ToString("Sábado");
                    break;
                default:
                    tb2.Text = "Número Invalido";
                    break;
            }
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            if(tb1.Text != "")
            {
                bt3.Enabled = true;
                bt4.Enabled = true;
            }
            else
            {
                bt3.Enabled = false;
                bt4.Enabled = false;
            }
        }
               
    }
}
