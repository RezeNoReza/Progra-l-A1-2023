using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int j, t, q, m, num; //Reze

            j = 0;
            t = 1;

            listBox1.Items.Add(j);
            listBox1.Items.Add(t);

            num = Convert.ToInt32(textBox1.Text);

            for(m= 3; m<=num; m++)
            {
                q = j + t;

                listBox1.Items.Add(q);

                j = t;
                t = q;


            }    
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            listBox1.Items.Clear();
        }
    }
}


