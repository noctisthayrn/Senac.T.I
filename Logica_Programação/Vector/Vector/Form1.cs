using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector
{
    public partial class Form1 : Form
    {
        int num = 0;
        int[] number = new int[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            libNumber.Items.Clear();
            libResult.Items.Clear();

            btAdd.Enabled = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(num < 5)
            {
                number[num] = Convert.ToInt32(tbNumber.Text);
                num++;
                libNumber.Items.Add(tbNumber.Text);
                tbNumber.Clear();
                tbNumber.Focus();
            }
            else
            {
                tbNumber.Enabled = false;
                tbNumber.Clear();
                MessageBox.Show("Quantidade maxima de valores atingida");
            }
            
        }

        private void btCal_Click(object sender, EventArgs e)
        {
            double soma = 0;
            double media;
            int leng = number.Length;
            for (int i = 0; i < leng; i++)
            {
                soma += number[i];
            }
            media = soma / leng;
            tbSoma.Text = soma.ToString();            
            tbMedium.Text = media.ToString();
        }

        private void btOrganize_Click(object sender, EventArgs e)
        {
            Array.Sort(number);

            for(int i = 0; i < number.Length; i++)
            {
                libResult.Items.Add(number[i]);
            }
        }

        private void tbNumber_TextChanged(object sender, EventArgs e)
        {
            if (tbNumber.Text != "")
            {
                btAdd.Enabled = true;
            }
            else
            {
                btAdd.Enabled = false;
            }
        }
    }
}
