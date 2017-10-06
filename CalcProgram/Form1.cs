using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcProgram
{
    public partial class CalcProgramForm : Form
    {
        //Declaring Global Variables
        int input, operand, ansCache, ans;
        string inputString, operCache, cleared = "";
        char operation;
        bool operIsDone, enterClick = false; bool calc = true;

        string statusText;

        public CalcProgramForm()
        {
            InitializeComponent();
        }

        private void CalcProgramForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void MainCalc()
        {
            do
            {
                if (operation == '+')
                {
                    operand = stringToInt(inputString);
                    inputString = cleared;
                    ansCache += operand;
                    operand = 0;
                    break;
                }
                if (operation == '-')
                {
                    if (minusButton.Tag.Equals("1"))
                    {
                        operand = stringToInt(inputString);
                        inputString = cleared;
                        ansCache += operand;
                        minusButton.Tag = "2";
                        break;
                    }
                    else if (minusButton.Tag.Equals("2"))
                    {
                        operand = stringToInt(inputString);
                        inputString = cleared;
                        ansCache -= operand;
                        break;
                    }
                }
                if(operation == '*')
                {
                    if (timesButton.Tag.Equals("1"))
                    {
                        operand = stringToInt(inputString);
                        inputString = cleared;
                        ansCache += operand;
                        timesButton.Tag = "2";
                        break;
                    }
                    else if (timesButton.Tag.Equals("2"))
                    {
                        operand = stringToInt(inputString);
                        inputString = cleared;
                        ansCache *= operand;
                        break;
                    }
                }
                if(operation == '/')
                {
                    if (divideButton.Tag.Equals("1"))
                    {
                        operand = stringToInt(inputString);
                        inputString = cleared;
                        ansCache += operand;
                        divideButton.Tag = "2";
                        break;
                    }
                    else if (divideButton.Tag.Equals("2"))
                    {
                        operand = stringToInt(inputString);
                        inputString = cleared;
                        if (operand != 0)
                        {
                            ansCache /= operand;
                        }
                        else
                        {
                            statusLabel.Text = "Cannot Divide By Zero!";
                        }
                        break;
                    }
                }
                else if(operIsDone) { break; }
            }
            while (calc);

            if (operIsDone)
            {
                statusLabel.Text += " = " + Convert.ToString(ansCache) + "";
                statusText = statusLabel.Text;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text += " + ";
            operation = '+';
            MainCalc();
        }

        private void minusButton_Click(object sender, EventArgs e)
        { 
            statusLabel.Text += " - ";
            operation = '-';
            MainCalc();
        }

        private void timesButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text += " * ";
            operation = '*';
            MainCalc();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text += " / ";
            operation = '/';
            MainCalc();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            operIsDone = true;
            MainCalc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputString += "1";
            statusLabel.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inputString += "2";
            statusLabel.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inputString += "3";
            statusLabel.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inputString += "4";
            statusLabel.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inputString += "5";
            statusLabel.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inputString += "6";
            statusLabel.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inputString += "7";
            statusLabel.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inputString += "8";
            statusLabel.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            inputString += "9";
            statusLabel.Text += "9";
        }
      
        private void button10_Click(object sender, EventArgs e)
        {
            inputString += "0";
            statusLabel.Text += "0";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text = cleared;
            inputString = cleared;
            operation = ' ';
            input = 0;
            operand = 0;
            ansCache = 0;
            ans = 0;
            minusButton.Tag = "1";
            timesButton.Tag = "1";
            divideButton.Tag = "1";
            operIsDone = false;
        }

        private string intToString(int temp)
        {
            string convertedNum;
            convertedNum = Convert.ToString(temp);
            return convertedNum;
        }

        private int stringToInt(string temp)
        {
            int convertedString;
            convertedString = Convert.ToInt32(temp);
            return convertedString;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.NumPad0)
            {
                button10.PerformClick();
            }
            if (keyData == Keys.NumPad1)
            {
                button1.PerformClick();
            }
            if (keyData == Keys.NumPad2)
            {
                button2.PerformClick();
            }
            if (keyData == Keys.NumPad3)
            {
                button3.PerformClick();
            }
            if (keyData == Keys.NumPad4)
            {
                button4.PerformClick();
            }
            if (keyData == Keys.NumPad5)
            {
                button5.PerformClick();
            }
            if (keyData == Keys.NumPad6)
            {
                button6.PerformClick();
            }
            if (keyData == Keys.NumPad7)
            {
                button7.PerformClick();
            }
            if (keyData == Keys.NumPad8)
            {
                button8.PerformClick();
            }
            if (keyData == Keys.NumPad9)
            {
                button9.PerformClick();
            }
            if (keyData == Keys.Add)
            {
                addButton.PerformClick();
            }
            if (keyData == Keys.Subtract)
            {
                minusButton.PerformClick();
            }
            if (keyData == Keys.Multiply)
            {
                timesButton.PerformClick();
            }
            if (keyData == Keys.Divide)
            {
                divideButton.PerformClick();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }


        //NO OTHER EVENT CODE AFTER THIS LINE ******************************************************************************************************************

        private void statusLabel_Click(object sender, EventArgs e)
        {
            //no action on click
        }
   
    }
        
}
