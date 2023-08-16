using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verificar_Notas
{
    public partial class Form1 : Form
    {
        //Variaveis das notas
        decimal nota1;
        decimal nota2;
        decimal nota3;
        decimal nota4;

        //Veriavel Resultado
        decimal notaMaior;
        decimal notaMenor;
        decimal notaMedia;

        decimal[] notasT;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Desabilitar Botão Verificar
            bt1.Enabled = false;

            //Limpar as Nota Maior, Menor e Média
            tb5.Text = "";
            tb6.Text = "";
            tb7.Text = "";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            //validar Notas
            nota1 = Convert.ToInt32(tb1.Text);
            nota2 = Convert.ToInt32(tb2.Text);
            nota3 = Convert.ToInt32(tb3.Text);
            nota4 = Convert.ToInt32(tb4.Text);

            //Todas as Notas
            notasT = new decimal[4] { nota1, nota2, nota3, nota4 };

            //Nota Maior
            notaMaior = notasT.Max();
            tb5.Text = notaMaior.ToString();

            //Nota Menor
            notaMenor = notasT.Min();
            tb6.Text = notaMenor.ToString();

            //Nota Media
            notaMedia = (nota1 + nota2 + nota3 + nota4) / 4;
            tb7.Text = notaMedia.ToString();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            tb4.Text = "";
            tb1.Text = "";
            tb5.Text = "";
            tb6.Text = "";
            tb7.Text = "";
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            if(tb1.Text != "" && tb2.Text != "" && tb3.Text != "" && tb4.Text != "")
            {
                bt1.Enabled = true;
            }
            else
            {
                bt1.Enabled = false;
            }
        }

        private void tb3_TextChanged(object sender, EventArgs e)
        {
            if (tb1.Text != "" && tb2.Text != "" && tb3.Text != "" && tb4.Text != "")
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
            if (tb1.Text != "" && tb2.Text != "" && tb3.Text != "" && tb4.Text != "")
            {
                bt1.Enabled = true;
            }
            else
            {
                bt1.Enabled = false;
            }
        }

        private void tb4_TextChanged(object sender, EventArgs e)
        {
            if (tb1.Text != "" && tb2.Text != "" && tb3.Text != "" && tb4.Text != "")
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
