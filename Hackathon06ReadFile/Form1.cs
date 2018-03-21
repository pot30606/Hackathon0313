using Hackathon06ReadFile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon06ReadFile
{
    public partial class Form1 : Form
    {
        public static string filename;
        public Form1()
        {
            InitializeComponent();
            filename = "test02.txt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(filename))
            {
                SelectFirstThree obj = new SelectFirstThree();
                List<string> list = File.ReadAllLines(filename).ToList();
                MyPredicate find = findfirst3;
                var result = obj.DoWhere(list ,find);
                string st_date;
                string TickNumber;
                DateTime Flyingday;
                DateTime Birthday;
                foreach (var item in result)
                {
                    st_date = item.Substring(0, 13);
                    TickNumber = st_date;
                    st_date = item.Substring(13,8);
                    Flyingday = DateTime.ParseExact(st_date, "yyyyMMdd", null, System.Globalization.DateTimeStyles.AllowWhiteSpaces);
                    st_date = item.Substring(21, 8);
                    Birthday = DateTime.ParseExact(st_date, "yyyyMMdd", null, System.Globalization.DateTimeStyles.AllowWhiteSpaces);
                    InsertIntoDatabase(TickNumber , Flyingday , Birthday);
                }

            }
            else
            {
                MessageBox.Show("找不到檔案");
            }
        }

        private void InsertIntoDatabase(string TickNumber , DateTime Flyingday , DateTime Birthday)
        {
            ReadandConvert data = new ReadandConvert()
            {
                TickNumber = TickNumber, Flyingfay = Flyingday, Birthday = Birthday
            };
            try
            {
                Model1  model1= new Model1();
                model1.ReadandConvert.Add(data);
                model1.SaveChanges();
            }
            catch
            {
                MessageBox.Show("發生錯誤!");
            }
            
        }

        static bool findfirst3(string value)
        {
            if (value.IndexOf("695") == 0 || value.IndexOf("525") == 0)
            {
                return true;
            } 
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetDataFromDataBase();
        }

        private void GetDataFromDataBase()
        {
            var context = new Model1();
            var list = context.ReadandConvert.ToList();

            dataGridView1.DataSource = list;
        }

    }
}
