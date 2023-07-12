using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackerApp.Model
{
    public class WeightEntry
    {

        public DateTime Date { get; set; }
        public decimal Weight { get; set; }
        public string UserName { get; set; }
        public string GUID { get; set; }
    }
}
