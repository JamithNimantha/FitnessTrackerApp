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
    public partial class MainForm : Form
    {
        private readonly string _userName;
        public MainForm(string UserName)
        {
            _userName = UserName;
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new LoginForm();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { Application.Exit(); };
            form.ShowDialog();
            this.Dispose();
        }

        private void profileForm_Load(object sender, EventArgs e)
        {

        }
    }
}
