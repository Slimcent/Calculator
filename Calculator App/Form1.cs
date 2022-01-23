using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_App
{
    public partial class Form1 : Form
    {
        public Form1()
            

        {
            InitializeComponent();
        }



        double holding = 0;
        double answer = 0;
        string usedoperator;

        bool plusclicked = false;
        bool minusclicked = false;
        bool divclicked = false;
        bool multclicked = false;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {

            if (lblslimcent.Left < 600)
            {
                lblslimcent.Left = lblslimcent.Left + 1;
            }
            else
            {
                lblslimcent.Left = -lblslimcent.Width;
            }


        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblans.Text += btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblans.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblans.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblans.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblans.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblans.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblans.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblans.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblans.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblans.Text += btn9.Text;
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            lblans.Text += btndot.Text;
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            
            holding += holding + double.Parse(lblans.Text);
            usedoperator = "+";
            lblans.Clear();

            
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            double textans;

            textans = double.Parse(lblans.Text);


            holding = holding - textans;
            usedoperator = "-";
            lblans.Clear();

            
            
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            double textans;

            textans = double.Parse(lblans.Text);

            holding = holding * textans;
            usedoperator = "*";
            lblans.Clear();

            
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            double textans;

            textans = double.Parse(lblans.Text);
            
            
                holding = holding / textans;
                usedoperator = "/";
                lblans.Clear();

                
            
           
        }

        private void btnequal_Click(object sender, EventArgs e)
        {

            double textholding;

            textholding = double .Parse (lblans .Text);

            switch (usedoperator)
            {
                case "+":
                    answer = holding + textholding;
                    lblans.Text = answer.ToString();
                    holding = 0;
                    break;

                case "-":
                    answer = holding - textholding;
                    lblans.Text = answer.ToString();
                    holding = 0;
                    break;

                case "*":
                    answer = holding * textholding;
                    lblans.Text = answer.ToString();
                    holding = 0;
                    break;

                case "/":
                    answer = holding / textholding;
                    lblans.Text = answer.ToString();
                    holding = 0;
                    break;

                default:

                    answer = 0;
                    break;
            }

        }
    }
}
