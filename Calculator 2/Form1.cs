using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_2
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

                 Button b = sender as Button;
                 if (txtans.Text == "0")
                 {
                     txtans.Text = b.Text;
                 }
                 else
                 {
                     txtans.Text += b.Text;
                 }
               
             }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
