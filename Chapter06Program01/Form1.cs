using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter06Program01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool flag;
            int val;
            string output="Number is " ;

            //Convert from text to number
            flag = int.TryParse(txtNumber.Text, out val);
            if (flag == false)
            {
                MessageBox.Show("Not a number. Re-enter.");
                txtNumber.Clear();
                txtNumber.Focus();
                return;

            }

            //See if odd or even

            /*if(val % 2 == 1)
            {
                output += "odd";
            }
            else
            {
                output += "even";
            }*/

            output = (val % 2 == 0) ? "Number is even " : "Number is Odd";

            //Show resul-t
            txtOutput.Text = output;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
