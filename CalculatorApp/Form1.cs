using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Calculator flags
        public bool num1 = true;
        public bool num2 = false;

        public string numb1;
        public string numb2;

        public bool AddF = false;
        public bool SubF = false;
        public bool MultF = false;
        public bool DivF = false;

        //Answer values
        double ans = 0;
        double prevAns = 0;

        //Utility Methods
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        //Button Clicks
        private void btn1_Click(object sender, EventArgs e)
        {
            if (num1)
            {
                numb1 += 1;
                calcView.Text = numb1;
            }
            else
            {
                numb2 += 1;
                calcView.Text = numb2;
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (num1)
            {
                numb1 += 2;
                calcView.Text = numb1;
            }
            else
            {
                numb2 += 2;
                calcView.Text = numb2;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (num1)
            {
                numb1 += 3;
                calcView.Text = numb1;
            }
            else
            {
                numb2 += 3;
                calcView.Text = numb2;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (num1)
            {
                numb1 += 4;
                calcView.Text = numb1;
            }
            else
            {
                numb2 += 4;
                calcView.Text = numb2;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (num1)
            {
                numb1 += 5;
                calcView.Text = numb1;
            }
            else
            {
                numb2 += 5;
                calcView.Text = numb2;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (num1)
            {
                numb1 += 6;
                calcView.Text = numb1;
            }
            else
            {
                numb2 += 6;
                calcView.Text = numb2;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (num1)
            {
                numb1 += 9;
                calcView.Text = numb1;
            }
            else
            {
                numb2 += 9;
                calcView.Text = numb2;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (num1)
            {
                numb1 += 8;
                calcView.Text = numb1;
            }
            else
            {
                numb2 += 8;
                calcView.Text = numb2;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (num1)
            {
                numb1 += 7;
                calcView.Text = numb1;
            }
            else
            {
                numb2 += 7;
                calcView.Text = numb2;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (num1)
            {
                numb1 += 0;
                calcView.Text = numb1;
            }
            else
            {
                numb2 += 0;
                calcView.Text = numb2;
            }
        }
        //Action buttons
        private void Eql_Click(object sender, EventArgs e)
        {
            if (AddF)
            {
                ans = Add(Convert.ToDouble(numb1), Convert.ToDouble(numb2));
            }

            if (SubF)
            {
                ans = Subtract(Convert.ToInt32(numb1), Convert.ToInt32(numb2));

            }

            if (MultF)
            {
                ans = Multiply(Convert.ToInt32(numb1), Convert.ToInt32(numb2));

            }

            if (DivF)
            {
                ans = Divide(Convert.ToInt32(numb1), Convert.ToInt32(numb2));

            }

            //Show answer in text box.
            calcView.Text = Convert.ToString(ans);

            //previous answer = ans.
            prevAns = ans;

            //reset flags
            num1 = true; num2 = false;
            numb1 = numb2 = "";

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (num1)
            {
                num1 = false;
                num2 = true;
                AddF = true;

            }
        }

        private void Sub_Click(object sender, EventArgs e)

        {
            if (num1)
            {
                num1 = false;
                num2 = true;
                SubF = true;

            }
        }

        private void Div_Click(object sender, EventArgs e)
        {
            if (num1)
            {
                num1 = false;
                num2 = true;
                DivF = true;

            }
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            if (num1)
            {
                num1 = false;
                num2 = true;
                MultF = true;

            }
        }
        private void Clr_Click(object sender, EventArgs e)
        {
            //Resets all values and sets flags to default

            //Flags
            num1 = true;
            num2 = false;

            //Utility flags
            AddF = SubF = DivF = MultF = false;

            //Numbs
            numb1 = numb2 = "";


            //Calc view
            calcView.Text = "0";
        }

        private void calcView_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrevAns_Click(object sender, EventArgs e)
        {
            if (num1)
            {
                numb1 = Convert.ToString(prevAns);
                calcView.Text = numb1;

            }
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            if (num1)
            {
                numb1 += ".";
                calcView.Text = numb1;
            }
            else
            {
                numb2 += ".";
                calcView.Text = numb2;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (num1)
            {
                numb1 = numb1.Substring(0, numb1.Length - 1);
                calcView.Text = numb1;
            }
            else
            {
                numb2 = numb2.Substring(0, numb2.Length - 1);
                calcView.Text = numb2;
            }
        }
    }
}