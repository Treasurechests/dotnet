using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        int m1, m3, m5, m7, x;

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            m1 = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            x = 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            m3 = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            x = 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            m5 = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            x = 3;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            m7 = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            x = 4;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(x==1)
            {
                String m2 = textBox1.Text;
                int a = m1 + Convert.ToInt32(m2);
                textBox1.Text = a.ToString();
            }
            else if(x==2)
            {
                String m4 = textBox1.Text;
                int b = m3 - Convert.ToInt32(m4);
                textBox1.Text = b.ToString();
            }
            else if(x==3)
            {
                String m6 = textBox1.Text;
                int c = m5 * Convert.ToInt32(m6);
                textBox1.Text = c.ToString();
            }
            else
            {
                String m8 = textBox1.Text;
                int d = m7/ Convert.ToInt32(m8);
                textBox1.Text = d.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

    }