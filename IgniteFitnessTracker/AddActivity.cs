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

namespace IgniteFitnessTracker
{
    public partial class AddActivity : Form
    {
        private Activity activity;

        public AddActivity()
        {
            InitializeComponent();
        }

        private void cancelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open dashboard form
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clears metrics
            activityText.Text = string.Empty;
            metric1Text.Text = string.Empty;
            metric2Text.Text = string.Empty;
            metric3Text.Text = string.Empty;
        }

        private void addActivityButton_Click(object sender, EventArgs e)
        {
            // Gets metrics from Activity.cs
            String activityOption = activityText.Text.ToLower();
            if (activityOption == "walking" || activityOption == "swimming" || activityOption == "basketball" || activityOption == "biking" || activityOption == "yoga" || activityOption == "tennis")
            {
                activity = new Activity(activityOption);
                // Guard case for user input
                if (int.TryParse(metric1Text.Text, out int result1) && int.TryParse(metric2Text.Text, out int result2) && int.TryParse(metric3Text.Text, out int result3))
                {
                    int m1 = int.Parse(metric1Text.Text);
                    int m2 = int.Parse(metric2Text.Text);
                    int m3 = int.Parse(metric3Text.Text);

                    int cal = activity.getCalories(m1, m2, m3);

                    // Adds activities to a .txt file, it copies old activities to save data
                    StreamReader input;
                    StreamWriter output;
                    string filename = "activities.txt";
                    string path = Path.Combine(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 9), filename);

                    input = new StreamReader(path);
                    String old = input.ReadToEnd();
                    input.Close();


                    output = new StreamWriter(path);
                    output.WriteLine(old);
                    output.WriteLine(activityOption);
                    output.WriteLine(cal.ToString());
                    output.Close();
                }
                else
                {
                    MessageBox.Show("Please enter a valid number");
                }



            }
            // Open dashboard form
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();



        }

        private void activityText_Leave(object sender, EventArgs e)
        {
            // Updates metrics to fit activity
            String activityOption = activityText.Text.ToLower();
            if (activityOption == "walking" || activityOption == "swimming" || activityOption == "basketball" || activityOption == "biking" || activityOption == "yoga" || activityOption == "tennis")
            {
                activity = new Activity(activityOption);
                metric1.Text = activity.getMetrics[0];
                metric2.Text = activity.getMetrics[1];
                metric3.Text = activity.getMetrics[2];
            }



        }

        
    }
}
