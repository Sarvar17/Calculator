using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {

        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        bool nextOperation = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculatorTextBox.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if(calculatorTextBox.Text == "0" || isOperationPerformed)
            {
                calculatorTextBox.Clear();
            }
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!calculatorTextBox.Text.Contains("."))
                {
                    calculatorTextBox.Text = calculatorTextBox.Text + button.Text;
                }
            }
            else
            {
                calculatorTextBox.Text = calculatorTextBox.Text + button.Text;
            }

            isOperationPerformed = false;
            
            if(calculatorLabel.Text=="")
            {
                nextOperation = false;
            }
            else
            {
                nextOperation = true;
            }
            
            if (!nextOperation)
            {
                calculatorLabel.Text = calculatorTextBox.Text;
            }
            else
            {

            }
        }

        private void operatorClick(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = double.Parse(calculatorTextBox.Text);
            isOperationPerformed = true;
            nextOperation = true;
            calculatorLabel.Text = calculatorLabel.Text + operationPerformed;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculatorTextBox.Text = "";
            resultValue = 0;
            calculatorLabel.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    calculatorTextBox.Text = (resultValue + double.Parse(calculatorTextBox.Text)).ToString();
                    break;

                case "/":
                    calculatorTextBox.Text = (resultValue / double.Parse(calculatorTextBox.Text)).ToString();
                    break;

                case "*":
                    calculatorTextBox.Text = (resultValue * double.Parse(calculatorTextBox.Text)).ToString();
                    break;

                case "-":
                    calculatorTextBox.Text = (resultValue - double.Parse(calculatorTextBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            calculatorLabel.Text = "";
        }
    }
}
