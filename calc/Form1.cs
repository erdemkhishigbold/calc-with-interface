using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        string operand1 = string.Empty;
        string operand2 = string.Empty;

        double result;
        double opr1, opr2;

        char operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnTwo.Text;

        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnSeven.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnZero.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnPeriod.Text;

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operand1 = textBox1.Text;
            operation = '+';
            textBox1.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                operand2 = textBox1.Text;

                opr1 = Double.Parse(operand1);
                opr2 = Double.Parse(operand2);


                switch (operation)
                {
                    case '+':
                        result = (opr1 + opr2);
                        break;

                    case '-':
                        result = (opr1 - opr2);
                        break;

                    case '*':
                        result = (opr1 * opr2);
                        break;

                    case '/':
                        if (opr2 != 0)
                        {
                            result = (opr1 / opr2);
                        }
                        else
                        {
                            MessageBox.Show("Can't divide by zero");
                        }
                        break;
                }

                textBox1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operand1 = textBox1.Text;
            operation = '/';
            textBox1.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            opr1 = 0;
            opr2 = 0;
            textBox1.Text = string.Empty;
        }

        private void btnDifference_Click(object sender, EventArgs e)
        {
            operand1 = textBox1.Text;
            operation = '-';
            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operand1 = textBox1.Text;
            operation = '*';
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }
    }
    // Test
}
