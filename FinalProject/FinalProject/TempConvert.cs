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
    public partial class TempConvert : Form
    {
        public TempConvert()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte val2 = 0;
            val2 = Convert.ToByte(MessageBox.Show("Do you want to quit the application Money Exchange?", "Exit ?", MessageBoxButtons.YesNo));
            if (val2 == 6)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = dir + "FileTempConvert.txt";
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);

            string d = DateTime.Now.ToString();
            double val1 = 0;
            double answer = 0;
            string convfrom = "";
            string convto = "";
            try
            {
                 val1 = double.Parse(textBox1.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "Please enter the appropriate value");
                return;
            }            

            if (radioButton1.Checked)
            {
                convfrom = "C";
                convto = "F";
                answer = (val1 * (1.8) + 32);
                textBox2.Text = answer.ToString();
                 if (textBox1.Text=="100")
                {
                    richTextBox1.Text = "Water Boils";                    
                }               
                
               else if (textBox1.Text == "40")
                {
                    richTextBox1.Text = "Hot Bath";
                }
               
                else if (textBox1.Text == "37")
                {
                    richTextBox1.Text = "Body Temperature";
                }
                
                else if (textBox1.Text == "30")
                {
                    richTextBox1.Text = "Beach Weather";
                }
               
                else if (textBox1.Text == "21")
                {
                    richTextBox1.Text = "Room Temperature";
                }
                
                else if (textBox1.Text == "10")
                {
                    richTextBox1.Text = "Cold Day";
                }
               
                else if (textBox1.Text == "0")
                {
                    richTextBox1.Text = "Freezing point of water";
                }
                
                else if (textBox1.Text == "-18")
                {
                    richTextBox1.Text = "Very Cold day";
                }
                
                else if (textBox1.Text == "-40")
                {
                    richTextBox1.Text = "Extremely cold day";
                }

                else
                {
                    richTextBox1.Clear();
                }
            }

            if (radioButton2.Checked)
            {
                convfrom = "F";
                convto = "C";
                answer = ((val1 - 32) / 1.8);
                textBox2.Text = answer.ToString();
                if (textBox1.Text == "212")
                {
                    richTextBox1.Text = "Water Boils";
                }
               
                else if (textBox1.Text == "104")
                {
                    richTextBox1.Text = "Hot Bath";
                }
               
               else if (textBox1.Text == "98.6")
                {
                    richTextBox1.Text = "Body Temperature";
                }
                
                else if (textBox1.Text == "86")
                {
                    richTextBox1.Text = "Beach Weather";
                }
                
                else if (textBox1.Text == "70")
                {
                    richTextBox1.Text = "Room Temperature";
                }
               
                else if (textBox1.Text == "50")
                {
                    richTextBox1.Text = "Cold Day";
                }
               
                else if (textBox1.Text == "32")
                {
                    richTextBox1.Text = "Freezing point of water";
                }
               
                else if (textBox1.Text == "0")
                {
                    richTextBox1.Text = "Very Cold day";
                }
                
                else if (textBox1.Text == "-40")
                {
                    richTextBox1.Text = "Extremely cold day"+ "\n" + "(and the same number)";                    

                }
                else
                {
                    richTextBox1.Clear();
                }

            }
            StreamWriter textOut = new StreamWriter(fs);
            textOut.Write(val1 +" "+ convfrom +" "+ "=" +" "+ answer +" "+ convto +","+" " + d + "\r\n");
            textOut.Close();
            fs.Close();
        }
        //string dir = @"C:\Users\Gurleen Singh\Desktop\C# Project\FinalProject\FinalProject\bin\Debug\Files\";
        string dir = @"./Files/";
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "F";
            label3.Text = "C";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "C";
            label3.Text = "F";
        }

        private void TempConvert_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = dir + "FileTempConvert.txt";
            FileStream fs = null;
            try
            { 
                StreamReader sr = new StreamReader(@"C:\Users\Gurleen Singh\Desktop\C# Project\FinalProject\FinalProject\bin\Debug\Files\FileTempConvert.txt");
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
}
