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
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_Pressed = false;
        bool decimal_Pressed = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_Pressed))
            {
                result.Clear();
                operation_Pressed = false;
            }
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            decimal_Pressed = false;
        }
        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_Pressed = true;
            decimal_Pressed = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    result.Text = addition(value, Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = subtraction(value, Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = multiplication(value, Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = division(value, Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            operation_Pressed = false;
            decimal_Pressed = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
            decimal_Pressed = false;
        }
        private void decimal_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_Pressed))
            {
                result.Clear();
                operation_Pressed = false;
                decimal_Pressed = false;
            }
            //Button b = (Button)sender;
            if (!decimal_Pressed) { 
                result.Text = result.Text + ".";
                decimal_Pressed = true;
            }
        }
        public static double addition(double i, double j)
        {
            double result = i + j;
            return result;

        }
        public static double subtraction(double i, double j)
        {
            double result = i - j;
            return result;

        }
        public static double multiplication(double i, double j)
        {
            double result = i * j;
            return result;

        }
        public static double division(double i, double j)
        {
            double result = i / j;
            return result;

        }
    }
}
