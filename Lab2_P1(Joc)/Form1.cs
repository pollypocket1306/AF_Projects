using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_P1_Joc_
{
    public partial class Form1 : Form
    {
        MyGraphics T = new MyGraphics();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            T.InitGraph(pcbDisplay);
            Engine.Load("../../Maps/demo1.txt");
            Engine.DoMath(T);
            Engine.Draw(T);
            T.RefreshGraph();

        }
    }
}
