using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Aulno
{
    public partial class Form1 : Form
    {
        // Varial das Notas do Aluno
        int nota1 = 0;
        int nota2 = 0;
        int nota3 = 0;
        int nota4 = 0;

        decimal finalnota = 0;

        string apro = "Aprovado";
        string recu = "Recuperação";
        string repr = "Reprovado";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            //Verificar se as quatros notas foram inseridas
            if (tb_3.Text != "" && tb_4.Text != "" && tb_5.Text != "" && tb_6.Text != "")
            {
                // Converter Nota
                nota1 = Convert.ToInt32(tb_3.Text);
                nota2 = Convert.ToInt32(tb_4.Text);
                nota3 = Convert.ToInt32(tb_5.Text);
                nota4 = Convert.ToInt32(tb_6.Text);

                // Calcular Media
                finalnota = (nota1 + nota2 + nota3 + nota4) / 4;                               
                
                if(finalnota >= 7)
                {
                    tb8.Text = apro;
                }
                
                else if(finalnota >= 5 && finalnota <= 6)
                {
                    tb8.Text = recu;
                }

                else
                {
                    tb8.Text = repr;
                }

                tb_7.Text = finalnota.ToString();
            }

            else
            {
                MessageBox.Show("Preencher todas as notas");
            }
        }

        private void b_3_Click(object sender, EventArgs e)
        {
            //Limpar Caixa das Notas
            tb_3.Text = "";
            tb_4.Text = "";
            tb_5.Text = "";
            tb_6.Text = "";

            //Limpar Nota Final
            tb_7.Text = "Resultado:";
            tb8.Text = "";
        }
    }
}
