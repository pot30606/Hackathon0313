using Hackathon02FuelsRecord.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon02FuelsRecord
{
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
            SetValue();
        }

        private void SetValue()
        {
            numericUpDown1.Minimum = 0;
            numericUpDown2.Minimum = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertIntoDataBase();
        }

        private void InsertIntoDataBase()
        {
            FuelRecord data = new FuelRecord()
            {
                Liter = (float)numericUpDown1.Value,
                RefuelingDate= dateTimePicker1.Value,
                Kilometer= (float)numericUpDown2.Value
            };
            try
            {
                FuelRecordModel fuelRecordModel = new FuelRecordModel();
                fuelRecordModel.FuelRecord.Add(data);
                fuelRecordModel.SaveChanges();
                MessageBox.Show("儲存成功!");
            }
            catch
            {
                MessageBox.Show("發生錯誤!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
