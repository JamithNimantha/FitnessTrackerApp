namespace FitnessTrackerApp.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.tabWorkout = new System.Windows.Forms.TabPage();
            this.tabCheatMeal = new System.Windows.Forms.TabPage();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.profileForm = new FitnessTrackerApp.View.ProfileForm(this._userName);
            this.profileForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDashboard);
            this.tabControl1.Controls.Add(this.tabWorkout);
            this.tabControl1.Controls.Add(this.tabCheatMeal);
            this.tabControl1.Controls.Add(this.tabProfile);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1113, 621);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDashboard
            // 
            this.tabDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabDashboard.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDashboard.Location = new System.Drawing.Point(4, 25);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDashboard.Size = new System.Drawing.Size(1105, 592);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // tabWorkout
            // 
            this.tabWorkout.Location = new System.Drawing.Point(4, 25);
            this.tabWorkout.Name = "tabWorkout";
            this.tabWorkout.Padding = new System.Windows.Forms.Padding(3);
            this.tabWorkout.Size = new System.Drawing.Size(1105, 592);
            this.tabWorkout.TabIndex = 1;
            this.tabWorkout.Text = "Workout";
            this.tabWorkout.UseVisualStyleBackColor = true;
            // 
            // tabCheatMeal
            // 
            this.tabCheatMeal.Location = new System.Drawing.Point(4, 25);
            this.tabCheatMeal.Name = "tabCheatMeal";
            this.tabCheatMeal.Size = new System.Drawing.Size(1105, 592);
            this.tabCheatMeal.TabIndex = 2;
            this.tabCheatMeal.Text = "Cheat Meal";
            this.tabCheatMeal.UseVisualStyleBackColor = true;
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.profileForm);
            this.tabProfile.Location = new System.Drawing.Point(4, 25);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Size = new System.Drawing.Size(1105, 592);
            this.tabProfile.TabIndex = 3;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // profileForm
            // 
            this.profileForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileForm.Location = new System.Drawing.Point(0, 0);
            this.profileForm.Name = "profileForm";
            this.profileForm.Size = new System.Drawing.Size(1105, 592);
            this.profileForm.TabIndex = 0;
            this.profileForm.Load += new System.EventHandler(this.profileForm_Load);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Location = new System.Drawing.Point(1039, -2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 25);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 620);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Personal Fitness Tracker App";
            this.tabControl1.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.TabPage tabWorkout;
        private System.Windows.Forms.TabPage tabCheatMeal;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.Button btnLogout;
        private ProfileForm profileForm;
    }
}