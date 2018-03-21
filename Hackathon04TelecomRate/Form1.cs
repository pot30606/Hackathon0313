using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon04TelecomRate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearLabelText();
            Caculate();
        }

        private void ClearLabelText()
        {
            lb_money.Text = "";
            lb_cheapest.Text = "";
        }

        private void Caculate()
        {
            int minutes = int.Parse(textBox1.Text);
            int ChungHua = 350 + minutes * 4;
            int YuanChuan = 400 + minutes * 3;
            int Taiwan = 500 + minutes * 2;
            List<cc> list = new List<cc>()
            {
                new cc(){name="中華電信",PricePerMin=4,Total=ChungHua},
                new cc(){name="遠傳",PricePerMin=3,Total=YuanChuan},
                new cc(){name="台灣大哥大",PricePerMin=2,Total=Taiwan}
            };
            count(list);
        }

        private void count(List<cc> list)
        {
            var max = list.Max((x) => x.Total);
            foreach(var item in list)
            {
                if(item.Total == max)
                {
                    lb_cheapest.Text += item.name + " ";
                    lb_money.Text = item.Total.ToString()+"元";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
