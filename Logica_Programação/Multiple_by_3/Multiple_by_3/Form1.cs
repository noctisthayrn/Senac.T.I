using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_by_3
{
    public partial class Form1 : Form
    {
        int result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btFor_Click(object sender, EventArgs e)
        {
            libResult.Items.Clear();
            libResult.Items.Add("For");

            for(int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    libResult.Items.Add(i);
                }
            }
        }

        private void btWhile_Click(object sender, EventArgs e)
        {
            libResult.Items.Clear();
            libResult.Items.Add("While");

            int i = 1;

            while(i <= 100)
            {
                if (i % 3 == 0)
                {
                    libResult.Items.Add(i);
                }

                i++;
            }
        }

        private void btDoWhile_Click(object sender, EventArgs e)
        {
            libResult.Items.Clear();
            libResult.Items.Add("Do While");

            int i = 1;
            do
            {
                if (i % 3 == 0)
                {
                    libResult.Items.Add(i);
                }

                i++;
            }
            while (i <= 100);
        }
    }
}
