using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            libResult.Items.Clear();

            btFor.Enabled = false;
            btWhile.Enabled = false;
            btDoWhile.Enabled = false;
        }

        private void tbNumber_TextChanged(object sender, EventArgs e)
        {
            if(tbNumber.Text != "")
            {
                btFor.Enabled = true;
                btWhile.Enabled = true;
                btDoWhile.Enabled = true;
            }
            else
            {
                libResult.Items.Clear();
                btFor.Enabled = false;
                btWhile.Enabled = false;
                btDoWhile.Enabled = false;
            }
        }

        private void btFor_Click(object sender, EventArgs e)
        {
            libResult.Items.Clear();

            int number = Convert.ToInt32(tbNumber.Text);
            int result = 0;

            for(int i = 0; i <= 10; i++)
            {
                result = number * i;
                libResult.Items.Add(number + "*" + i + "=" + result);
            }
        }

        private void btWhile_Click(object sender, EventArgs e)
        {
            libResult.Items.Clear();

            int number = Convert.ToInt32(tbNumber.Text);
            int result = 0;
            int i = 0;

            while(i <= 10)
            {
                result = number * i;
                libResult.Items.Add(number + "*" + i + "=" + result);
                i++;
            }
        }

        private void btDoWhile_Click(object sender, EventArgs e)
        {
            libResult.Items.Clear();

            int number = Convert.ToInt32(tbNumber.Text);
            int result = 0;
            int i = 0;

            do
            {
                result = number * i;
                libResult.Items.Add(number + "*" + i + "=" + result);
                i++;
            }
            while (i <= 10);
        }
    }
}
