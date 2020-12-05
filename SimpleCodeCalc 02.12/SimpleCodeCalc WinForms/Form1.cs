using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCodeCalc_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstValue, secondValue;
            firstValue = Convert.ToDouble(textBox1.Text);
            secondValue = Convert.ToDouble(textBox2.Text);

            switch(comboBox1.Text)
            {
                case "+":
                    textBox3.Text = Convert.ToString(firstValue + secondValue);
                    break;
                case "-":
                    textBox3.Text = Convert.ToString(firstValue - secondValue);
                    break;
                case "*":
                    textBox3.Text = Convert.ToString(firstValue * secondValue);
                    break;
                case "/":
                    if (secondValue == 0)
                    {
                        MessageBox.Show("Нельзя делить на ноль!");
                    }
                    textBox3.Text = Convert.ToString(firstValue / secondValue);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
        }
    }
}
