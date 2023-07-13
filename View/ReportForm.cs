using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessTrackerApp.Enumeration;

namespace FitnessTrackerApp.View
{
    public partial class ReportForm : UserControl
    {
        public ReportForm(string _userName)
        {
            InitializeComponent();
            Clear();
        }

        public void Clear()
        { 
            cmbReportType.DataSource = Enum.GetValues(typeof(ReportType));
            this.datePickerEndDate.MaxDate = DateTime.Today;
            this.datePickerStartDate.Value = DateTime.Today.Subtract(TimeSpan.FromDays(30));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void datePickerWeightEntryDate_ValueChanged(object sender, EventArgs e)
        {
            this.datePickerEndDate.MinDate = this.datePickerStartDate.Value;
        }

        private void cmbIntensity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
