using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgniteFitnessTracker
{
    public class Activity
    {
        // This class asks for metrics and calculates the calories burned based on the activity

        // Initializing Activity attributes
        private String activityType;
        private String[] metrics;

        // Constructer
        public Activity(string activityType)
        {
            // Returns metrics
            this.activityType = activityType;
            switch (this.activityType)
            {
                case "walking":
                    metrics = new string[] { "Steps", "Distance (m)", "Time (min)" };
                    break;
                case "swimming":
                    metrics = new string[] { "Number of Laps", "Avg Heart Rate", "Time (min)" };
                    break;
                case "basketball":
                    metrics = new string[] { "Intensity (1/2/3)", "Court Size (1/2)", "Time (min)" };
                    break;
                case "biking":
                    metrics = new string[] { "Intensity (1/2/3)", "Distance (m)", "Time (min)" };
                    break;
                case "yoga":
                    metrics = new string[] { "Intensity (1/2/3)", "Active Time (min)", "Time (min)" };
                    break;
                case "tennis":
                    metrics = new string[] { "Intensity (1/2/3)", "Singles/Doubles (1/2)", "Time (min)" };
                    break;
            }
        }

        // Get metrics method
        public String[] getMetrics { get { return metrics; } }

        // Get calories method
        public int getCalories(int metric1, int metric2, int metric3)
        {
            // Calculates calories burned based on metric provided
            switch (this.activityType)
            {
                case "walking":
                    if (metric1 < metric2)
                    {
                        return (int) (metric2 * 0.06);
                    }
                    else
                    {
                        return (int) (metric1 * 0.04);
                    }
                case "swimming":
                    return (int)  (metric3 * 8.7);

                case "basketball":
                    return (int) (metric1 * 3 * metric3 * 0.0175 * 60);

                case "biking":
                    return (int) (metric1 * 2 * metric3 * 0.0175 * 60);

                case "yoga":
                    return (int) (3 * metric3 * 0.0175 * 60);
                
                case "tennis":
                    return (int) (metric1 * 2.5 * metric3 * 0.0175 * 60);

            }
            return 1;
        }


    }
}
