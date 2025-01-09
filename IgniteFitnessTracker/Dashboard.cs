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
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace IgniteFitnessTracker
{
    public partial class Dashboard : Form
    {
        // Dashboard attributes
        private int calorieGoal = 0;
        private List<String> activities = new List<String>();
        private int calorieTotal = 0;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Display user name 
            StreamReader input;
            string filename = "users.txt";
            string path = Path.Combine(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 9), filename);

            input = new StreamReader(path);
            String name = input.ReadLine();
            welcomeText.Text = $"Welcome, {name}";
            input.Close();

            // Add activity to a list of activities
            filename = "activities.txt";
            path = Path.Combine(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 9), filename);

            input = new StreamReader(path);
            String line;
            while ((line = input.ReadLine()) != null)
            {
                if (line != string.Empty)
                {
                    activities.Add(line);
                }

            }
            input.Close();

            // Display calorie data in chart
            DisplayCalorieChart();

            // Displays recent activities
            if (activities.Count >= 6)
            {
                activity1.Text = activities[activities.Count - 2];
                activity2.Text = activities[activities.Count - 4];
                activity3.Text = activities[activities.Count - 6];
            }
            if (activities.Count == 4)
            {
                activity1.Text = activities[activities.Count - 2];
                activity2.Text = activities[activities.Count - 4];
                activity3.Text = "...";
            }
            if (activities.Count == 2)
            {
                activity1.Text = activities[activities.Count - 2];
                activity2.Text = "...";
                activity3.Text = "...";
            }

            for (int i = 1; i < activities.Count; i += 2)
            {
                calorieTotal += int.Parse(activities[i]);
            }

            totalCalories.Text = calorieTotal.ToString();


            // Read caloric goal and saves it
            filename = "calorieGoal.txt";
            path = Path.Combine(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 9), filename);
            input = new StreamReader(path);
            calorieGoal = int.Parse(input.ReadLine());
            input.Close();

            // Checks whether or not caloric goal has been met
            if (calorieTotal > calorieGoal)
            {
                totalGoal.ForeColor = Color.Green;
                goalAchieved.Text = "Acheived";
                goalAchieved.ForeColor = Color.Green;

                
            }
            if (calorieTotal < calorieGoal)
            {
                totalGoal.ForeColor = Color.Red;
                goalAchieved.Text = "Not Acheived";
                goalAchieved.ForeColor = Color.Red;
            }


            // Display calorie goal and total calories burned
            totalGoal.Text = $"{calorieGoal.ToString()} / {calorieTotal.ToString()}";

        }

        private void DisplayCalorieChart()
        {
            // Create or configure a Chart control
            Chart calorieChart = new Chart
            {
                Location = new Point(40, 300), // Bottom-left corner, adjust Y for padding
                Size = new Size(546, 230), // Set size of the chart
                Anchor = AnchorStyles.Left | AnchorStyles.Bottom, // Ensures it stays in the bottom-left corner on resize
                BackColor = Color.Transparent,

            };
            this.Controls.Add(calorieChart);

            // Add a ChartArea
            ChartArea chartArea = new ChartArea("CalorieArea")
            {
                BackColor = Color.Transparent, // Make the chart area background transparent
                AxisX = { LabelStyle = { ForeColor = Color.White }, TitleForeColor = Color.White }, // Make X-axis labels and title white
                AxisY = { LabelStyle = { ForeColor = Color.White }, TitleForeColor = Color.White }  // Make Y-axis labels and title white
            };
            calorieChart.ChartAreas.Add(chartArea);

            // Add a Series for the calorie data
            Series series = new Series("Calories")
            {
                ChartType = SeriesChartType.Column, // Use a bar chart
                BorderWidth = 2,
                Color = Color.FromArgb(255, 128, 0),
                LabelForeColor = Color.White
            };
            calorieChart.Series.Add(series);

            // Add data points (calories and corresponding activities)
            for (int i = 0; i < activities.Count; i += 2)
            {
                string activityName = activities[i];
                int calorieValue = int.Parse(activities[i + 1]);

                series.Points.AddXY(activityName, calorieValue);
            }

            // Add a title
            Title chartTitle = new Title
            {
                Text = "Calorie Tracker",
                ForeColor = Color.White, // Title text in white
                Font = new Font("Arial", 14, FontStyle.Bold)
            };
            calorieChart.Titles.Add(chartTitle);

            // Customize axes
            chartArea.AxisX.Title = "Activities";
            chartArea.AxisY.Title = "Calories Burned";
        }


        private void logooutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open login form
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void goalButton_Click(object sender, EventArgs e)
        {
            // Sets goal and saves it in a .txt file
            StreamWriter output;
            string filename = "calorieGoal.txt";
            string path = Path.Combine(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 9), filename);
            output = new StreamWriter(path);

            
            // Guard case for user input
            if (int.TryParse(goalText.Text, out int result))
            {
                output.WriteLine(goalText.Text);
                MessageBox.Show($"Goal set {goalText.Text} calories");
            }
            else
            {
                MessageBox.Show("Please enter a valid number Ex.300");

            }
            output.Close();

            // Clear activities for new goal
            filename = "activities.txt";
            path = Path.Combine(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 9), filename);
            output = new StreamWriter(path);
            output.WriteLine(string.Empty);
            output.Close();

        }

        private void activityButton_Click(object sender, EventArgs e)
        {
            // Opens add activity form
            AddActivity addActivity = new AddActivity();
            addActivity.Show(); 
            this.Close();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            // Updates calorie goal and calorie total
            totalGoal.Text = $"{calorieGoal.ToString()} / {calorieTotal.ToString()}";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
