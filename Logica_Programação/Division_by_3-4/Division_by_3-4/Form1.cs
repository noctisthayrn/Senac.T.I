using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Division_by_3_4
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

            libResult.Items.Add("Usando For");

            libResult.Items.Add("Divisíveis por 3");

            for(int i = 0; i <= 30; i++)
            {
                if(i % 3 == 0)
                {
                    libResult.Items.Add(i + " Esse número é divivel por 3");
                }
            }

            libResult.Items.Add("Divisíveis por 4");

            for (int i = 0; i <= 30; i++)
            {
                if (i % 4 == 0)
                {
                    libResult.Items.Add(i + " Esse número é divivel por 4");
                }
            }
        }

        private void btWhile_Click(object sender, EventArgs e)
        {
            libResult.Items.Clear();

            int i = 0;

            libResult.Items.Add("Usando While");

            libResult.Items.Add("Divisíveis por 3");

            while (i <= 30)
            {
                if (i % 3 == 0)
                {
                    libResult.Items.Add(i + " Esse número é divivel por 3");
                }

                i++;
            }

            i = 0;

            libResult.Items.Add("Divisíveis por 4");

            while (i <= 30)
            {
                if (i % 4 == 0)
                {
                    libResult.Items.Add(i + " Esse número é divivel por 4");
                }

                i++;
            }
        }

        private void btDoWhile_Click(object sender, EventArgs e)
        {
            libResult.Items.Clear();

            int i = 0;

            libResult.Items.Add("Usando Do While");

            libResult.Items.Add("Divisíveis por 3");

            do
            {
                if (i % 3 == 0)
                {
                    libResult.Items.Add(i + " Esse número é divivel por 3");
                }

                i++;
            }
            while (i <= 30);

            i = 0;

            libResult.Items.Add("Divisíveis por 4");

            do
            {
                if (i % 4 == 0)
                {
                    libResult.Items.Add(i + " Esse número é divivel por 4");
                }

                i++;
            }
            while (i <= 30);
        }
    }
}
