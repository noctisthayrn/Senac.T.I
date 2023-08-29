using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Division_by_4
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
        }

        private void btFor_Click(object sender, EventArgs e)
        {
            libResult.Items.Clear();

            libResult.Items.Add("For");

            for(int i = 0; i <= 200; i++)
            {
                if(i % 4 == 0 && i < 200)
                {
                    libResult.Items.Add(i + " Esse número é divivel por 4");
                }
            }
        }

        private void btWhile_Click(object sender, EventArgs e)
        {
            libResult.Items.Clear();

            libResult.Items.Add("While");

            int i = 0;

            while(i <= 200)
            {
                if (i % 4 == 0 && i < 200)
                {
                    libResult.Items.Add(i + " Esse número é divivel por 4");
                }
                i++;
            }
        }

        private void btDoWhile_Click(object sender, EventArgs e)
        {
            libResult.Items.Clear();

            libResult.Items.Add("Do While");

            int i = 0;

            do
            {
                if (i % 4 == 0 && i < 200)
                {
                    libResult.Items.Add(i + " Esse número é divivel por 4");
                }
                i++;
            }
            while (i <= 200);
        }
    }
}
