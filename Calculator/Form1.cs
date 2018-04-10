using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Caclulator : Form
    {
        string input = string.Empty; 
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;


        public Caclulator()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.txtAnswer.Text = "";
            input += "1";
            this.txtAnswer.Text += input;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.txtAnswer.Text = "";
            input += "2";
            this.txtAnswer.Text += input;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.txtAnswer.Text = "";
            input += "3";
            this.txtAnswer.Text += input;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.txtAnswer.Text = "";
            input += "4";
            this.txtAnswer.Text += input;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.txtAnswer.Text = "";
            input += "5";
            this.txtAnswer.Text += input;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.txtAnswer.Text = "";
            input += "6";
            this.txtAnswer.Text += input;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.txtAnswer.Text = "";
            input += "7";
            this.txtAnswer.Text += input;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.txtAnswer.Text = "";
            input += "8";
            this.txtAnswer.Text += input;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.txtAnswer.Text = "";
            input += "9";
            this.txtAnswer.Text += input;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.txtAnswer.Text = "";
            input += "0";
            this.txtAnswer.Text += input;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {

            input += ".";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtAnswer.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            this.txtAnswer.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;

            if(operation =='+')
            {
                result = num1 + num2;
                txtAnswer.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                txtAnswer.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                txtAnswer.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if(num2 != 0)
                {
                    result = num1 / num2;
                    txtAnswer.Text = result.ToString();
                }
                else
                {
                    txtAnswer.Text = "Can't Divide by Zero!";
                }

            }
        }
    }
}
