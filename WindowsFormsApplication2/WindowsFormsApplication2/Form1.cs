using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s=0;
            while (s <= 100)
            {
                listBox1.Items.Add(s);
                s++; 
            }
            if (s % 2 == 0)
            {


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int a = 0; a <= 100; a++)
            {
                if (a % 2 == 1)
                {
                    listBox2.Items.Add(a);
                }
            }
        }
    }
}
