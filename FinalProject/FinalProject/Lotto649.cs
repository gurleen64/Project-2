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
    public partial class Lotto649 : Form
    {
        public Lotto649()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte val1 = 0;
            val1 = Convert.ToByte(MessageBox.Show("Do you want to quit the application Money Exchange?", "Exit ?", MessageBoxButtons.YesNo));
            if (val1 == 6)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texttoPrint = "";
            string texttoShow = "";
            Random random = new Random();
            for (int i = 0; i < 7; i++)
            {              
               
                    int randomNumber = random.Next(1, 49);             
                
                texttoPrint += randomNumber.ToString() + ",";
                texttoShow += randomNumber.ToString() + "\r\n";
            }
            
            richTextBox1.Text = texttoShow ;

            string path = dir + "File649.txt";
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);

            string d = DateTime.Now.ToString();

            StreamWriter textOut = new StreamWriter(fs);
            textOut.WriteLine("649, "+ d+" "+ texttoPrint+" "+ "Extra 23");
            textOut.Close();
            fs.Close();

        }
        //string dir = @"C:\Users\Gurleen Singh\Desktop\C# Project\FinalProject\FinalProject\bin\Debug\Files\";
        string dir = @"./Files/";
        private void Lotto649_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int linesNbr = 0;
            string textToPrint = "";
            string path = dir + "File649.txt"; 
            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                
                StreamReader textIn = new StreamReader(fs);
               
                while (textIn.Peek() != -1)
                {
                    textToPrint += textIn.ReadLine() + "\n";
                    linesNbr += 1;
                    if (linesNbr == 36)
                    {
                        MessageBox.Show(textToPrint);
                        linesNbr = 0;
                        textToPrint = "";
                    }
                }
                if (linesNbr > 0)
                {
                    MessageBox.Show(textToPrint);
                }
                textIn.Close();
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
