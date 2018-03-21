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
    public partial class Output : Form
    {
        public Output()
        {
            InitializeComponent();
            SetValueIntoGridView();
        }

        private void SetValueIntoGridView()
        {

            var context = new FuelRecordModel();
            var list = context.FuelRecord.ToList();
            
            dataGridView1.DataSource = list;
        }
    }
}
