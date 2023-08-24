using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loop_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            libMessage.Items.Clear();
            libQua.Items.Clear();
        }

        private void btMessage_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= 20; i++)
            {
                libMessage.Items.Add("Eu adoro estudar lógica de programação!");
            }
        }

        private void btCal_Click(object sender, EventArgs e)
        {
            double result = 0;
            for(int i = 15; i <= 500; i++)
            {
                result = Math.Pow(i, 2);
                libQua.Items.Add(i + "² ="+ result);
            }
        }
    }
}
