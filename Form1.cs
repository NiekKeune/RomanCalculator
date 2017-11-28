using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanCalculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        int result;
        int number;                            //variable to store the operand numbers in to convert

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Zero_Click(object sender, EventArgs e)
        {
            input += "0";
            Int32.TryParse(input, out number);                  //converts the string to int so it can be converted
            ConvertMethod(number);                              //sends the number variable to the convert method which will naturally convert it
        }

        private void One_Click(object sender, EventArgs e)
        {
            input += "1";
            Int32.TryParse(input, out number);
            ConvertMethod(number);
        }

        private void Two_Click(object sender, EventArgs e)
        {
            input += "2";
            Int32.TryParse(input, out number);
            ConvertMethod(number);
        }

        private void Three_Click(object sender, EventArgs e)
        {
            input += "3";
            Int32.TryParse(input, out number);
            ConvertMethod(number);
        }

        private void Four_Click(object sender, EventArgs e)
        {
            input += "4";
            Int32.TryParse(input, out number);
            ConvertMethod(number);
        }

        private void Five_Click(object sender, EventArgs e)
        {
            input += "5";
            Int32.TryParse(input, out number);
            ConvertMethod(number);
        }

        private void Six_Click(object sender, EventArgs e)
        {
            input += "6";
            Int32.TryParse(input, out number);
            ConvertMethod(number);
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            input += "7";
            Int32.TryParse(input, out number);
            ConvertMethod(number);
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            input += "8";
            Int32.TryParse(input, out number);
            ConvertMethod(number);
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            input += "9";
            Int32.TryParse(input, out number);
            ConvertMethod(number);
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void Division_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void ConvertMethod(int result)
        {
            string buffer;                              //variable to hold the roman numeral

            if (result > 0 & result < 3000)             //sets the boundaries for the roman number
            {
                string[] Thousands = { "", "M", "MM"};                                                  //creates arrays for the int variable to go through 
                string[] Hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };     //
                string[] Tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };         //
                string[] Ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };         //

                buffer = Thousands[result / 1000]; result = result % 1000;        //first it divides the result by a thousand to check if it has any thousands, if the number becomes less than 0, the array will give nothing. If it's 2000 for example it becomes 2 and will look for array position 2 to see what to replace it with, which is MM here.
                buffer += Hundreds[result / 100];  result = result % 100;         //then it'll change the result with the remainder function to work with the different arrays, so since it's done with the thousands it'll look for the remainder after being divided by 1000. The number 2347 will give the remainder 347 here.
                buffer += Tens[result / 10];       result = result % 10;          //this continues until the number is entirely processed
                buffer += Ones[result];                                           //the += adds to buffer string, which would mean if the number was 1494 that M CD XC and IV would turn out as a single string MCDXCIV

                textBox1.Text = buffer; }       //changes display to the roman numeral


            else 

                textBox1.Text = "Out of bounds.";   //to handle numbers that are below 0 or above 3000
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            int num1, num2;
            Int32.TryParse (operand1, out num1);        //converts the string operands to ints so it can be calculated with
            Int32.TryParse (operand2, out num2);        //

            if (operation == '+')
            {
                result = num1 + num2;
                ConvertMethod(result);
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                ConvertMethod(result);
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                ConvertMethod(result);
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    ConvertMethod(result);
                }
                else
                {
                    textBox1.Text = "Can't divide by zero.";
                }

            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }
    }
}
