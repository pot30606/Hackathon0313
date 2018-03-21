using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon05Palindrome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text;
            string m = "";
            var list = n.Reverse().ToList();
            foreach(var item in list)
            {
                m += item.ToString();
            }

            if (n==m)
            {
                label2.Text = "回文";
            }

        }
    }
}
