using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal num1 = 0;
        decimal num2 = 0;
        decimal result = 0;
        string Operator = "";
        bool isOperatorChosen = false;        // is a boolean variable that checks whether an operation operator (such as +, -, *, /) has been selected by the user.
        bool clearTextOnNextInput = false;    // is a boolean variable that determines whether the text in the display should be cleared the next time the user inputs a number or operator.


        private void btn1_Click(object sender, EventArgs e)
        {
            if (clearTextOnNextInput)         //If it is true, the condition works.
            {
                txtTotal.Clear();
                clearTextOnNextInput = false;
            }
            txtTotal.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (clearTextOnNextInput)
            {
                txtTotal.Clear();
                clearTextOnNextInput = false;
            }
            txtTotal.Text += btn2.Text;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (clearTextOnNextInput)
            {
                txtTotal.Clear();
                clearTextOnNextInput = false;
            }
            txtTotal.Text += btn3.Text;

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (clearTextOnNextInput)
            {
                txtTotal.Clear();
                clearTextOnNextInput = false;
            }
            txtTotal.Text += btn4.Text;

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (clearTextOnNextInput)
            {
                txtTotal.Clear();
                clearTextOnNextInput = false;
            }
            txtTotal.Text += btn5.Text;

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (clearTextOnNextInput)
            {
                txtTotal.Clear();
                clearTextOnNextInput = false;
            }
            txtTotal.Text += btn6.Text;

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (clearTextOnNextInput)
            {
                txtTotal.Clear();
                clearTextOnNextInput = false;
            }
            txtTotal.Text += btn7.Text;

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (clearTextOnNextInput)
            {
                txtTotal.Clear();
                clearTextOnNextInput = false;
            }
            txtTotal.Text += btn8.Text;

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (clearTextOnNextInput)
            {
                txtTotal.Clear();
                clearTextOnNextInput = false;
            }
            txtTotal.Text += btn9.Text;

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (clearTextOnNextInput)
            {
                txtTotal.Clear();
                clearTextOnNextInput = false;
            }
            txtTotal.Text += btn0.Text;

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTotal.Text)) //If you click an operator without entering num1, it gives an error.
            {
                MessageBox.Show("Please enter the first number before selecting an operator!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!isOperatorChosen)            //Due to the exclamation mark, !isOperatorChosen takes the opposite of its value. If it is true, it becomes false. So, in this case, the condition works if it is false.              
            {
                Operator = "+";               
                num1 = decimal.Parse(txtTotal.Text);
                lblHistory.Text = num1.ToString() + " + ";
                txtTotal.Clear();
                isOperatorChosen = true;      //To prevent operators from being entered consecutively.
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTotal.Text)) 
            {
                MessageBox.Show("Please enter the first number before selecting an operator!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!isOperatorChosen)
            {
                Operator = "-";
                num1 = decimal.Parse(txtTotal.Text);
                lblHistory.Text = num1.ToString() + " - ";
                txtTotal.Clear();
                isOperatorChosen = true;
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTotal.Text)) 
            {
                MessageBox.Show("Please enter the first number before selecting an operator!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!isOperatorChosen)
            {
                Operator = "/";
                num1 = decimal.Parse(txtTotal.Text);
                lblHistory.Text = num1.ToString() + " / ";
                txtTotal.Clear();
                isOperatorChosen = true;
            }

        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTotal.Text)) 
            {
                MessageBox.Show("Please enter the first number before selecting an operator!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!isOperatorChosen)
            {
                Operator = "*";
                num1 =  decimal.Parse(txtTotal.Text);
                lblHistory.Text = num1.ToString() + " * ";
                txtTotal.Clear();
                isOperatorChosen = true;
            }

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (!isOperatorChosen)
            {                               //If the equal sign is pressed when no operator is selected, nothing happens.
                return;                      
            }
            if (string.IsNullOrEmpty(txtTotal.Text)) //If you click = without entering num2, it throws an error.
            {
                MessageBox.Show("You have not entered the second number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            num2 = decimal.Parse(txtTotal.Text);

            switch (Operator)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "/":
                    result = num2 != 0 ? num1 / num2 : 0;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
            }

            lblHistory.Text += num2.ToString() + " = ";
            txtTotal.Text = result.ToString();
            isOperatorChosen = false;
            clearTextOnNextInput = true; 
            num1 = result;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            lblHistory.Text = "";
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; //prevents the key press from being processed by the control.You can also prevent keyboard input by setting read only to true.
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtTotal.Text.Contains("."))
            {
                if (txtTotal.Text == "")
                    txtTotal.Text = "0.";
                else 
                    txtTotal.Text += ".";

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text.Length > 0)
            {
                txtTotal.Text = txtTotal.Text.Substring(0, txtTotal.Text.Length - 1); //It means taking a part from inside a text (string).
            }
        }
    }
}
