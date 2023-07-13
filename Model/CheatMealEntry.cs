using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackerApp.Model
{
    public class CheatMealEntry
    {
        public DateTime Date { get; set; }
        public string UserName { get; set; }
        public string GUID { get; set; }
        public string MealName { get; set; }
        public decimal Calories { get; set; }
        public string WeightEntryGUID { get; set; }
    }
}
