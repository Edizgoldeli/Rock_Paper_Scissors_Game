using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors_Game
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

        private void textBox_Bot_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Ply_Click(object sender, EventArgs e)
        {
            double Rock=0;//1
            double Scissor=0;//2
            double Paper=0;//3
            double x=0;
            double a = 1;double b = 2;double c = 3;
            double[] decitions = new double[100];
            Random playerB = new Random();
            for(int i = 0; i < 100; i++)
            { Double decitionB = playerB.Next(1, 4);
                decitions[i] = decitionB;
                x = decitionB;
                if (x == a) { Rock++; }
                else if (x == b) { Scissor++; }
                else if (x == c) { Paper++; }
            }

            textBoxA.Text = "0";
            textBoxA2.Text = "100";
            textBoxA3.Text = "0";
            textBox_B.Text = Rock.ToString();
            textBox_B2.Text = Paper.ToString();
            textBox_B3.Text = Scissor.ToString();
            textBox_Rslt.Text = Rock.ToString();
            textBox_Rslt2.Text= Scissor.ToString();
            textBox_Rslt3.Text = Paper.ToString();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
