using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Um programa onde usuário digita um número entre 1 e 7 e exiba por extenso o dia da semana correspondente a cada número.

namespace Switch_Case
{
    public partial class Form1 : Form
    {
        int digitado = 0;
        string[] installs = new string[] { "1", "2", "3", "4", "5", "6", "7" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Desabilitar os botãos
            bt1.Enabled = false;
            bt2.Enabled = false;
            bt3.Enabled = false;
            bt4.Enabled = false;

            //Limpar a caixa de Resultado
            lb1.Text = "";
            lb2.Text = "";
        }

        //Verificar se o usuario escolher um número
        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cb1.Items.AddRange(installs);
            if(cb1.Text != "")
            {
                bt1.Enabled = true;
                bt2.Enabled = true;
            }
            else
            {
                bt1.Enabled = false;
                bt2.Enabled = false;
            }
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            
            CB_If();
        }

        private void bt2_Click(object sender, EventArgs e)
        {

            
            CB_Com();
        }

        //Virificar se o usuario ditar um número
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
        private void bt3_Click(object sender, EventArgs e)
        {
            digitado = Convert.ToInt32(tb1.Text);
            CB_If();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            digitado = Convert.ToInt32(tb1.Text);
            CB_Com();
        }        
        
        //Void para executar o pedido do botao usando IF
        private void CB_If()
        {
            if(digitado == 7)
            {
                lb2.Text = "Sábado";
            }
            else if(digitado == 6)
            {
                lb2.Text = "Sexta-feira";
            }
            else if(digitado == 5)
            {
                lb2.Text = "Quinta-feira";
            }
            else if (digitado == 4)
            {
                lb2.Text = "Quarta-feira";
            }
            else if (digitado == 3)
            {
                lb2.Text = "Terça-feira";
            }
            else if (digitado == 2)
            {
                lb2.Text = "Segunda-feira";
            }
            else
            {
                lb2.Text = "Domingo";
            }
        }

        //Void para executar o pedido do botao usando Switch Case
        private void CB_Com()
        {
            switch (digitado)
            {
                case 7:
                    lb2.Text = "Sábado";
                    break;
                case 6:
                    lb2.Text = "Sexta-feira";
                    break;
                case 5:
                    lb2.Text = "Quinta-feira";
                    break;
                case 4:
                    lb2.Text = "Quarta-feira";
                    break;
                case 3:
                    lb2.Text = "Terça-feira";
                    break;
                case 2:
                    lb2.Text = "Segunda-feira";
                    break;
                case 1:
                    lb2.Text = "Domingo";
                    break;
            }
        }
    }
}
