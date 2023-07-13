using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackerApp.Model
{
    public class WorkoutEntry
    {
        public DateTime Date { get; set; }
        public string WorkoutName { get; set; }
        public string UserName { get; set; }
        public string GUID { get; set; }
        public string Intensity { get; set; }
        public decimal CaloriesBurned { get; set; }
        public string WeightEntryGUID { get; set; }

    }
}
