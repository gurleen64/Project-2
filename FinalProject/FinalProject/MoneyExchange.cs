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

namespace FinalProject
{
    public partial class MoneyExchange : Form
    {
        public MoneyExchange()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte val1 = 0;
            val1 = Convert.ToByte(MessageBox.Show("Do you want to quit the application Money Exchange?","Exit ?",MessageBoxButtons.YesNo));
            if (val1==6)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = dir + "FileMoneyExchange.txt";
            FileStream fs = null;
            try
            {        
                StreamReader sr = new StreamReader(@"C:\Users\Gurleen Singh\Desktop\C# Project\FinalProject\FinalProject\bin\Debug\Files\FileMoneyExchange.txt");
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

        private void button1_Click(object sender, EventArgs e)
        {
            string path = dir + "FileMoneyExchange.txt";
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            
            string d = DateTime.Now.ToString();
            string convfrom = "";
            string convto = "";
            double amount = 0;
            double total = 0 ;
            try
            {
                amount = double.Parse(textBox1.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Please enter the appropriate value !");
            }
            if (radioButton1.Checked && radioButton11.Checked)
            {
                total = amount * 1;
                textBox2.Text = total.ToString();
                convfrom = "CAD";
                convto = "CAD";
            }

            if (radioButton1.Checked && radioButton12.Checked)
            {
                total = amount * 0.78;
                textBox2.Text = total.ToString();
                convfrom = "CAD";
                convto = "USD";

            }

            if (radioButton1.Checked && radioButton13.Checked)
            {
                total = amount * 0.65;
                textBox2.Text = total.ToString();
                convfrom = "CAD";
                convto = "EUR";
            }

            if (radioButton1.Checked && radioButton14.Checked)
            {
                total = amount * 0.58;
                textBox2.Text = total.ToString();
                convfrom = "CAD";
                convto = "GBP";
            }
            if (radioButton1.Checked && radioButton15.Checked)
            {
                total = amount * 52.44;
                textBox2.Text = total.ToString();
                convfrom = "CAD";
                convto = "INR";
            }

            if (radioButton2.Checked && radioButton11.Checked)
            {
                total = amount * 1.31;
                textBox2.Text = total.ToString();
                convfrom = "USD";
                convto = "CAD";
            }
            if (radioButton2.Checked && radioButton12.Checked)
            {
                total = amount * 1;
                textBox2.Text = total.ToString();
                convfrom = "USD";
                convto = "USD";
            }
            if (radioButton2.Checked && radioButton13.Checked)
            {
                total = amount * 0.86;
                textBox2.Text = total.ToString();
                convfrom = "USD";
                convto = "EUR";
            }
            if (radioButton2.Checked && radioButton14.Checked)
            {
                total = amount * 0.76;
                textBox2.Text = total.ToString();
                convfrom = "USD";
                convto = "GBP";
            }
            if (radioButton2.Checked && radioButton15.Checked)
            {
                total = amount * 68.93;
                textBox2.Text = total.ToString();
                convfrom = "USD";
                convto = "INR";
            }
            if (radioButton3.Checked && radioButton11.Checked)
            {
                total = amount * 1.54;
                textBox2.Text = total.ToString();
                convfrom = "EUR";
                convto = "CAD";
            }
            if (radioButton3.Checked && radioButton12.Checked)
            {
                total = amount * 1.17;
                textBox2.Text = total.ToString();
                convfrom = "EUR";
                convto = "USD";
            }
            if (radioButton3.Checked && radioButton13.Checked)
            {
                total = amount * 1;
                textBox2.Text = total.ToString();
                convfrom = "EUR";
                convto = "EUR";
            }
            if (radioButton3.Checked && radioButton14.Checked)
            {
                total = amount * 0.88;
                textBox2.Text = total.ToString();
                convfrom = "EUR";
                convto = "GBP";
            }
            if (radioButton3.Checked && radioButton15.Checked)
            {
                total = amount * 80.60;
                textBox2.Text = total.ToString();
                convfrom = "EUR";
                convto = "INR";
            }
            if (radioButton4.Checked && radioButton11.Checked)
            {
                total = amount * 1.74;
                textBox2.Text = total.ToString();
                convfrom = "GBP";
                convto = "CAD";
            }
            if (radioButton4.Checked && radioButton12.Checked)
            {
                total = amount * 1.32;
                textBox2.Text = total.ToString();
                convfrom = "GBP";
                convto = "USD";
            }
            if (radioButton4.Checked && radioButton13.Checked)
            {
                total = amount * 1.13;
                textBox2.Text = total.ToString();
                convfrom = "GBP";
                convto = "EUR";
            }
            if (radioButton4.Checked && radioButton14.Checked)
            {
                total = amount * 1;
                textBox2.Text = total.ToString();
                convfrom = "GBP";
                convto = "GBP";
            }
            if (radioButton4.Checked && radioButton15.Checked)
            {
                total = amount * 91.13;
                textBox2.Text = total.ToString();
                convfrom = "GBP";
                convto = "INR";
            }
            if (radioButton5.Checked && radioButton11.Checked)
            {
                total = amount * 0.019;
                textBox2.Text = total.ToString();
                convfrom = "INR";
                convto = "CAD";
            }
            if (radioButton5.Checked && radioButton12.Checked)
            {
                total = amount * 0.015;
                textBox2.Text = total.ToString();
                convfrom = "INR";
                convto = "USD";
            }
            if (radioButton5.Checked && radioButton13.Checked)
            {
                total = amount * 0.012;
                textBox2.Text = total.ToString();
                convfrom = "INR";
                convto = "EUR";
            }
            if (radioButton5.Checked && radioButton14.Checked)
            {
                total = amount * 0.011;
                textBox2.Text = total.ToString();
                convfrom = "INR";
                convto = "GBP";
            }
            if (radioButton5.Checked && radioButton15.Checked)
            {
                total = amount * 1;
                textBox2.Text = total.ToString();
                convfrom = "INR";
                convto = "INR";
            }

            StreamWriter textOut = new StreamWriter(fs);
            textOut.Write(amount +" "+ convfrom +" "+ "=" +" "+ total+" " + convto+","+" "  + d + "\r\n");
            textOut.Close();
            fs.Close();
            
            
        }
        //string dir = @"C:\Users\Gurleen Singh\Desktop\C# Project\FinalProject\FinalProject\bin\Debug\Files\";
        string dir = @"./Files/";
        private void MoneyExchange_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }
    }
}
