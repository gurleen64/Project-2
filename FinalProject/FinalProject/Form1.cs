using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LottoMax lm = new LottoMax();
            lm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lotto649 l = new Lotto649();
            l.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculator c = new Calculator();
            c.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MoneyExchange me = new MoneyExchange();
            me.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TempConvert tc = new TempConvert();
            tc.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
