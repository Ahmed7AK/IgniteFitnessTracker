namespace IgniteFitnessTracker
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.welcomeText = new System.Windows.Forms.Label();
            this.igniteLogo = new System.Windows.Forms.PictureBox();
            this.goalButton = new System.Windows.Forms.Button();
            this.goalText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalCalories = new System.Windows.Forms.Label();
            this.logooutLink = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.activityButton = new System.Windows.Forms.Button();
            this.activity2 = new System.Windows.Forms.Label();
            this.activity1 = new System.Windows.Forms.Label();
            this.activity3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalGoal = new System.Windows.Forms.Label();
            this.goalAchieved = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.igniteLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.welcomeText.Location = new System.Drawing.Point(23, 27);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(218, 31);
            this.welcomeText.TabIndex = 0;
            this.welcomeText.Text = "Welcome Ahmed";
            // 
            // igniteLogo
            // 
            this.igniteLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.igniteLogo.Image = ((System.Drawing.Image)(resources.GetObject("igniteLogo.Image")));
            this.igniteLogo.Location = new System.Drawing.Point(663, -1);
            this.igniteLogo.Margin = new System.Windows.Forms.Padding(2);
            this.igniteLogo.Name = "igniteLogo";
            this.igniteLogo.Size = new System.Drawing.Size(120, 120);
            this.igniteLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.igniteLogo.TabIndex = 20;
            this.igniteLogo.TabStop = false;
            // 
            // goalButton
            // 
            this.goalButton.BackColor = System.Drawing.Color.Red;
            this.goalButton.FlatAppearance.BorderSize = 0;
            this.goalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.goalButton.Location = new System.Drawing.Point(41, 150);
            this.goalButton.Name = "goalButton";
            this.goalButton.Size = new System.Drawing.Size(116, 36);
            this.goalButton.TabIndex = 21;
            this.goalButton.Text = "Set Goal";
            this.goalButton.UseVisualStyleBackColor = false;
            this.goalButton.Click += new System.EventHandler(this.goalButton_Click);
            // 
            // goalText
            // 
            this.goalText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.goalText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.goalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.goalText.Location = new System.Drawing.Point(41, 113);
            this.goalText.Name = "goalText";
            this.goalText.Size = new System.Drawing.Size(116, 31);
            this.goalText.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Calories:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Total Calories Burned:";
            // 
            // totalCalories
            // 
            this.totalCalories.AutoSize = true;
            this.totalCalories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.totalCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCalories.Location = new System.Drawing.Point(245, 244);
            this.totalCalories.Name = "totalCalories";
            this.totalCalories.Size = new System.Drawing.Size(26, 29);
            this.totalCalories.TabIndex = 25;
            this.totalCalories.Text = "0";
            // 
            // logooutLink
            // 
            this.logooutLink.AutoSize = true;
            this.logooutLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.logooutLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logooutLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logooutLink.Location = new System.Drawing.Point(709, 527);
            this.logooutLink.Name = "logooutLink";
            this.logooutLink.Size = new System.Drawing.Size(63, 20);
            this.logooutLink.TabIndex = 26;
            this.logooutLink.TabStop = true;
            this.logooutLink.Text = "Log out";
            this.logooutLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logooutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logooutLink_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Activties Log:";
            // 
            // activityButton
            // 
            this.activityButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.activityButton.FlatAppearance.BorderSize = 0;
            this.activityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.activityButton.Location = new System.Drawing.Point(41, 224);
            this.activityButton.Name = "activityButton";
            this.activityButton.Size = new System.Drawing.Size(116, 36);
            this.activityButton.TabIndex = 28;
            this.activityButton.Text = "Add Activity";
            this.activityButton.UseVisualStyleBackColor = false;
            this.activityButton.Click += new System.EventHandler(this.activityButton_Click);
            // 
            // activity2
            // 
            this.activity2.AutoSize = true;
            this.activity2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.activity2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activity2.Location = new System.Drawing.Point(247, 149);
            this.activity2.Name = "activity2";
            this.activity2.Size = new System.Drawing.Size(16, 16);
            this.activity2.TabIndex = 29;
            this.activity2.Text = "...";
            // 
            // activity1
            // 
            this.activity1.AutoSize = true;
            this.activity1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.activity1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activity1.Location = new System.Drawing.Point(247, 121);
            this.activity1.Name = "activity1";
            this.activity1.Size = new System.Drawing.Size(16, 16);
            this.activity1.TabIndex = 30;
            this.activity1.Text = "...";
            // 
            // activity3
            // 
            this.activity3.AutoSize = true;
            this.activity3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.activity3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activity3.Location = new System.Drawing.Point(247, 178);
            this.activity3.Name = "activity3";
            this.activity3.Size = new System.Drawing.Size(16, 16);
            this.activity3.TabIndex = 31;
            this.activity3.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(475, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 24);
            this.label9.TabIndex = 32;
            this.label9.Text = "Goal:";
            // 
            // totalGoal
            // 
            this.totalGoal.AutoSize = true;
            this.totalGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.totalGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalGoal.ForeColor = System.Drawing.Color.Red;
            this.totalGoal.Location = new System.Drawing.Point(477, 113);
            this.totalGoal.Name = "totalGoal";
            this.totalGoal.Size = new System.Drawing.Size(50, 24);
            this.totalGoal.TabIndex = 33;
            this.totalGoal.Text = "0 / ...";
            // 
            // goalAchieved
            // 
            this.goalAchieved.AutoSize = true;
            this.goalAchieved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.goalAchieved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalAchieved.ForeColor = System.Drawing.Color.Red;
            this.goalAchieved.Location = new System.Drawing.Point(476, 248);
            this.goalAchieved.Name = "goalAchieved";
            this.goalAchieved.Size = new System.Drawing.Size(103, 20);
            this.goalAchieved.TabIndex = 35;
            this.goalAchieved.Text = "Not Achieved";
            this.goalAchieved.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(476, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Goal Status:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.goalAchieved);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalGoal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.activity3);
            this.Controls.Add(this.activity1);
            this.Controls.Add(this.activity2);
            this.Controls.Add(this.activityButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.logooutLink);
            this.Controls.Add(this.totalCalories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goalText);
            this.Controls.Add(this.goalButton);
            this.Controls.Add(this.igniteLogo);
            this.Controls.Add(this.welcomeText);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Click += new System.EventHandler(this.Dashboard_Click);
            ((System.ComponentModel.ISupportInitialize)(this.igniteLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.PictureBox igniteLogo;
        private System.Windows.Forms.Button goalButton;
        private System.Windows.Forms.TextBox goalText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalCalories;
        private System.Windows.Forms.LinkLabel logooutLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button activityButton;
        private System.Windows.Forms.Label activity2;
        private System.Windows.Forms.Label activity1;
        private System.Windows.Forms.Label activity3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label totalGoal;
        private System.Windows.Forms.Label goalAchieved;
        private System.Windows.Forms.Label label4;
    }
}