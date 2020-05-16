using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int Find_NWD(int val1, int val2)
        {
            do
            {
                if (val1 > val2)
                {
                    val1 = val1 - val2;
                }
                else
                {
                    val2 = val2 - val1;
                }
            }
            while (val1 != val2) ;

            return val1;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int value1 = int.Parse(textBox1.Text);
            int value2 = int.Parse(textBox2.Text);
            int NWD = Find_NWD(value1, value2);
            
            label3.Text = "NWD dla liczb " + value1 + " i " + value2 + " wynosi " + Convert.ToString(NWD);
        }
    }
}
