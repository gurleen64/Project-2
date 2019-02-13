using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;

namespace FinalProject
{
    
    public partial class Calculator : Form
    {
        Double firstvalue = 0;
        string operationperformed = "";
        bool val1 = false;
        public Calculator()
        {
            InitializeComponent();
        }
        string dir = @"./Files/";

        private void button18_Click(object sender, EventArgs e)
        {
            byte val2 = 0;
            val2 = Convert.ToByte(MessageBox.Show("Do you want to quit the application Calculator?", "Exit ?", MessageBoxButtons.YesNo));
            if (val2 == 6)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text=="0")|| val1)
            {
                textBox1.Clear();
            }
            val1 = false;
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
            op1.EnteredValue1 = Convert.ToDouble(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationperformed = button.Text;
            firstvalue = Double.Parse(textBox1.Text);
            op1.EnteredValue = Convert.ToDouble(firstvalue);
            val1 = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            firstvalue = 0;
            textBox2.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string path = dir + "Calculator.txt";
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);

            switch (operationperformed)
            {
                case "+":
                    //textBox2.Text = (firstvalue + Double.Parse(textBox1.Text)).ToString();
                    textBox2.Text = op1.sum().ToString();
                    break;
                case "-":
                    //textBox2.Text = (firstvalue - Double.Parse(textBox1.Text)).ToString();
                    textBox2.Text = op1.substraction().ToString();
                    break;
                case "*":
                    //textBox2.Text = (firstvalue * Double.Parse(textBox1.Text)).ToString();
                    textBox2.Text = op1.multiplication().ToString();
                    break;
                case "/":
                    //textBox2.Text = (firstvalue / Double.Parse(textBox1.Text)).ToString();
                    textBox2.Text = op1.division().ToString();
                    break;

                default:
                    break;
            }
            string d = DateTime.Now.ToString();
            StreamWriter textOut = new StreamWriter(fs);
            textOut.Write("Calculator, "+d+" "+firstvalue +" "+operationperformed +" "+textBox1.Text+" = " +textBox2.Text +  "\r\n");
            textOut.Close();
            fs.Close();
        }
        operations op1;
        private void Calculator_Load(object sender, EventArgs e)
        {
            op1 = new operations();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string path = dir + "Calculator.txt";
            FileStream fs = null;
            try
            {
                StreamReader sr = new StreamReader(@"C:\Users\Gurleen Singh\Desktop\C# Project\FinalProject\FinalProject\bin\Debug\Files\Calculator.txt");
                string text = sr.ReadToEnd();
                MessageBox.Show(text, "Read File");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(path + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(path + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) fs.Close(); }
        }
    }

    class operations
    {
        private double enteredValue;
        private double enteredValue1;

        public double EnteredValue
        {
            set { enteredValue = value; }
            get { return enteredValue; }
        }
        public double EnteredValue1
        {
            set { enteredValue1 = value; }
            get { return enteredValue1; }
        }
        public operations() { }
        public operations(double num1, double num2)
        {
            enteredValue = num1;
            enteredValue1 = num2;
        }
        public double sum()
        { return (EnteredValue + EnteredValue1); }
        public double substraction()
        { return (EnteredValue - EnteredValue1); }
        public double multiplication()
        { return (EnteredValue * EnteredValue1); }
        public double division()
        { return (EnteredValue / EnteredValue1); }


    }
}
