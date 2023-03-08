using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs1_P1
{
    public partial class Form1 : Form
    {
        Random rnd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lstbContent.Items.Clear();
            rnd = new Random();
            int[] array = new int[5];
            int[] frecv = new int[15];

            for (int i = 0; i < 5; i++)
            {
                array[i] = rnd.Next(2, 15);
                frecv[array[i]]++;
                lstbContent.Items.Add(array[i]);
            }

            string buffer = "";
            int max = frecv[0];
            int min = frecv[0];
            int cont2 = 0;

            for (int i = 0; i < 15; i++)
            {
                buffer += frecv[i] + " ";

                if (frecv[i] > max)
                {
                    max = frecv[i];
                }

                if (frecv[i] < min)
                {
                    min = frecv[i];
                }

                if (frecv[i] == 2)
                {
                    cont2++;
                }
            }
            //lstbContent.Items.Add(buffer);

            if (max == 5)
            {
                lblResult.Text = "5";
            }
            else if (max == 4)
            {
                lblResult.Text = "4";
            }
            else if (max == 3 && cont2 == 1)
            {
                lblResult.Text = "3 & 2";
            }
            else if (max == 3)
            {
                lblResult.Text = "3";
            }
            else if (cont2 == 2)
            {
                lblResult.Text = "2 & 2";
            }
            else if (cont2 == 1)
            {
                lblResult.Text = "2";
            }
            else
            {
                lblResult.Text = "No Case";
            }
        }
    }
}
