using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulyator
{
    public partial class Form1 : Form
    {
        Double a = 0;
        string s = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {   if (textBox1.Text =="0")
                textBox1.Clear();
            Button k=(Button)sender;
            textBox1 .Text = textBox1.Text+k.Text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a=Double.Parse(textBox1.Text);
            textBox1.Text= "0";
            s = "/";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            a = Double.Parse(textBox1.Text);
            textBox1.Text = "0";
            s = "x";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = Double.Parse(textBox1.Text);
            textBox1.Text = "0";
            s = "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = Double.Parse(textBox1.Text);
            textBox1.Text = "0";
            s = "+";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch(s)
            {
                case "/":
                    textBox1.Text=(a/Double.Parse(textBox1.Text)).ToString(); break;

                case "x":
                    textBox1.Text=(a*Double.Parse(textBox1.Text)).ToString(); break;
                        
                case "-":
                    textBox1.Text=(a-Double.Parse(textBox1.Text)).ToString();break;

                case "+":
                    textBox1.Text=(a+Double.Parse(textBox1.Text)).ToString(); break;

                case "%":
                    textBox1.Text = (a * Double.Parse(textBox1.Text)*0.01).ToString(); break;    

                default: break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a=Double.Parse(textBox1.Text);
            textBox1.Text = "0";
            s = "%";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" && textBox1.Text.Length > 1)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else if (textBox1.Text.Length == 1 || textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }
    }
}
