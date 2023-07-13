using System.Collections.Generic;

namespace FitnessTrackerApp.Utility
{
    public class Util
    {
        public static readonly string SALT_STRING = "7q3df*(&T*TKJ@*&!YTFSD*&";
        public static readonly string JSON_STORAGE_PATH = @"";
        public Util() { }

        public static List<string> GetIntensityTypes()
        {
            var intensities = new List<string>();
            intensities.Add("Low");
            intensities.Add("Moderate");
            intensities.Add("High");
            intensities.Add("Intense");
            return intensities;
        }
    }
}
