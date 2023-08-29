using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector_Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btInt_Click(object sender, EventArgs e)
        {
            libResult.Items.Add("Vector Int");

            int[] numero = {0, 1, 2, 3, 4, 5, 6 };

            for(int i = 0; i < numero.Length; i++)
            {
                libResult.Items.Add(numero[i]);
            }

        }

        private void btString_Click(object sender, EventArgs e)
        {
            libResult.Items.Add("Vector String");

            string[] dias = { "Domingo", "Segunda-Feira", "Terça-Feira", "Quarta-Feira", "Quinta-Feira", "Sexta-Feira", "Sábado" };
            for(int i = 0; i < dias.Length; i++)
            {
                libResult.Items.Add(dias[i]);
            }
        }
    }
}
