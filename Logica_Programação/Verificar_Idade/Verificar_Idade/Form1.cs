using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verificar_Idade
{
    public partial class bt1 : Form
    {
        public bt1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb2.Text = "";
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            if(tb1.Text == "")
            {
                bt2.Enabled = false;
            }
            else
            {
                bt2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Variavel idade
            int idade = Convert.ToInt32(tb1.Text);

            //Verificar se a idade é maior que 18
            if(idade >= 18)
            {
                tb2.Text = "ACESSO AUTORIZADO";
                tb2.ForeColor = Color.Green;
            }
            else
            {
                tb2.Text = "ACESSO NEGADO";
                tb2.ForeColor = Color.Red;
            }
        }
    }
}
