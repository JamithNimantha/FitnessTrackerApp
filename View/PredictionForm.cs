using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTrackerApp.View
{
    public partial class PredictionForm : UserControl
    {
        private readonly string _userName;
        public PredictionForm(string UserName)
        {
            InitializeComponent();
            _userName = UserName;
        }
    }
}
