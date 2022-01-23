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
        public Form1()
        {
            InitializeComponent();
        }

        double value;
        string usedopetator;
        bool check;

         private void forbuttons(object sender, EventArgs e)
        {


            if ((usedopetator == "+") || (usedopetator == "-") || (usedopetator == "*") || (usedopetator == "/"))
            {
                if (check)
                {
                    check = false;
                    txtans.Text = "0";
                }

                Button b = (Button)sender;
                if (txtans.Text == "0")
                
                    txtans.Text = b.Text;
                
                else
                
                    txtans.Text += b.Text;
                


            }
         }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void buttonClicking(object sender, EventArgs e)
        {
            if (txtans.Text == "0")
            {
                txtans.Clear();
            }

            Button button = (Button)sender;
            txtans.Text = txtans.Text + button .Text;

        }

       


        }
    

}
