using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorLib;
namespace WindowsCalcuApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CalcuClass cal;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cal = new CalcuClass();
            cal.Num1 = Convert.ToInt32(txtNum1.Text);
            cal.Num2 = Convert.ToInt32(txtNum2.Text);
            lblResult.Text= "Addition of the two numbers:"+cal.Add().ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            cal = new CalcuClass();
            cal.Num1 = Convert.ToInt32(txtNum1.Text);
            cal.Num2 = Convert.ToInt32(txtNum2.Text);
            lblResult.Text = "Subtraction of the two numbers:" + cal.Sub().ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            cal = new CalcuClass();
            cal.Num1 = Convert.ToInt32(txtNum1.Text);
            cal.Num2 = Convert.ToInt32(txtNum2.Text);
            lblResult.Text = "Multiplication of the two numbers:" + cal.Mul().ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            cal = new CalcuClass();
            cal.Num1 = Convert.ToInt32(txtNum1.Text);
            cal.Num2 = Convert.ToInt32(txtNum2.Text);
            lblResult.Text = "Division of the two numbers:" + cal.Div().ToString();
        }
    }
}
