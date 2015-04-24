using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048_2D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class_Number doubi = new Class_Number();
        private void up_Click(object sender, EventArgs e)
        {
            Button ass=(Button)sender;
            label1.Text = doubi.Final_Output(ass);
        }

        private void left_Click(object sender, EventArgs e)
        {
            Button ass = (Button)sender;
            label1.Text = doubi.Final_Output(ass);
        }

        private void down_Click(object sender, EventArgs e)
        {
            Button ass = (Button)sender;
            label1.Text = doubi.Final_Output(ass);
        }

        private void right_Click(object sender, EventArgs e)
        {
            Button ass = (Button)sender;
            label1.Text = doubi.Final_Output(ass);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doubi.restart();
            label1.Text = "";
        }
    }
}
