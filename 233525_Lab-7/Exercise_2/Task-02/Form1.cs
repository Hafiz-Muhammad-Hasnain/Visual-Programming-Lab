using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_02
{
    public partial class Form1 : Form
    {

        private double result = 0;
        private string operation = "";
        private bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        // Number Buttons
        private void button1_Click(object sender, EventArgs e) // Button for "0"
        {
            AddNumber("1");
        }

        private void button2_Click(object sender, EventArgs e) // Button for "1"
        {
            AddNumber("4");
        }

        private void button3_Click(object sender, EventArgs e) // Button for "2"
        {
            AddNumber("7");
        }

        private void button4_Click(object sender, EventArgs e) // Button for "3"
        {
            AddNumber(".");
        }

        private void button5_Click(object sender, EventArgs e) // Button for "4"
        {
            AddNumber("2");
        }

        private void button6_Click(object sender, EventArgs e) // Button for "5"
        {
            AddNumber("5");
        }

        private void button7_Click(object sender, EventArgs e) // Button for "6"
        {
            AddNumber("8");
        }

        private void button8_Click(object sender, EventArgs e) // Button for "7"
        {
            AddNumber("0");
        }

        private void button9_Click(object sender, EventArgs e) // Button for "8"
        {
            AddNumber("3");
        }

        private void button10_Click(object sender, EventArgs e) // Button for "9"
        {
            AddNumber("6");
        }

        private void AddNumber(string number)
        {
            if ((textBox1.Text == "0") || isOperationPerformed)
                textBox1.Clear();

            isOperationPerformed = false;
            textBox1.Text += number;
        }

        // Operator Buttons
        private void button11_Click(object sender, EventArgs e) // Button for "+"
        {
            SetOperation("9");
        }

        private void button13_Click(object sender, EventArgs e) // Button for "*"
        {
            SetOperation("+");
        }

        private void button14_Click(object sender, EventArgs e) // Button for "/"
        {
            SetOperation("-");
        }
        private void button15_Click(object sender, EventArgs e) // Button for "-"
        {
            SetOperation("*");
        }
        private void button16_Click(object sender, EventArgs e) // Button for "-"
        {
            SetOperation("/");
        }

        private void SetOperation(string op)
        {
            operation = op;
            result = Double.Parse(textBox1.Text);
            isOperationPerformed = true;
        }

        // Equal Button
        private void button17_Click(object sender, EventArgs e) // Button for "="
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
            }
            result = Double.Parse(textBox1.Text);
            operation = "";
            textBox1.Text = result.ToString();
        }

        // Clear Button
        private void button12_Click(object sender, EventArgs e) // Button for "C"
        {
            textBox1.Text = "0";
            result = 0;
            operation = "";
            isOperationPerformed = false;



        }

        // private double result = 0;
        // private string operation = "";


        // private bool isOperationPerformed = false;
        //public Form1()
        //{
        //    InitializeComponent();
        // }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        /* double firstNumber, secondNumber, result;

     private void button1_Click(object sender, EventArgs e)
     {
         textBox1.Text=button1.Text;
     }

     string operation;*?

     private void button17_Click(object sender, EventArgs e)
     {
         textBox1.Text=result.ToString();
     }



     /* private void button_Click(object sender, EventArgs e)
      {
          if ((textBox1.Text == "0") || (isOperationPerformed))
              textBox1.Clear();

          isOperationPerformed = false;
          Button button = (Button)sender;
          textBox1.Text = textBox1.Text + button.Text;
      }

      private void operator_Click(object sender, EventArgs e)
      {
          Button button = (Button)sender;
          operation = button.Text;
          result = Double.Parse(textBox1.Text);
          isOperationPerformed = true;
      }

      private void btnEqual_Click(object sender, EventArgs e)
      {
          switch (operation)
          {
              case "+":
                  textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                  break;
              case "-":
                  textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                  break;
              case "*":
                  textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                  break;
              case "/":
                  textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                  break;
          }
          result = Double.Parse(textBox1.Text);
          operation = "";
      }

      private void btnClear_Click(object sender, EventArgs e)
      {
          textBox1.Text = "0";
          result = 0;
          operation = "";
      }*/



    }



    }

