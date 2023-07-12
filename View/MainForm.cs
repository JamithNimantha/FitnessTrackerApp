using System;
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
            LoadProfileTab();
            LoadWeightEntryTab();
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

        private void LoadProfileTab()
        {
            var profileForm = new ProfileForm(this._userName);
            profileForm.Dock = System.Windows.Forms.DockStyle.Fill;
            profileForm.Location = new System.Drawing.Point(0, 0);
            profileForm.Name = "profileForm";
            profileForm.Size = new System.Drawing.Size(1105, 592);
            profileForm.TabIndex = 0;
            this.tabProfile.Controls.Add(profileForm);
        }

        private void LoadWeightEntryTab()
        {
            var weightEntryForm = new WeightEntryForm(this._userName);
            weightEntryForm.AutoScaleMode = AutoScaleMode.Dpi;
            weightEntryForm.Dock = System.Windows.Forms.DockStyle.Fill;
            weightEntryForm.Name = "weightEntryForm";         
           
            this.tabWeight.AutoSize = true; 
            this.tabWeight.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.tabWeight.Controls.Add(weightEntryForm);



        }

    }
}
