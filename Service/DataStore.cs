using FitnessTrackerApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackerApp.Service
{
    public class DataStore
    {
        public static Dictionary<String, User> userMap = new Dictionary<String, User>();

        public static HashSet<User> userStore = new HashSet<User>();



        public static HashSet<User> UserStore
        {
            get { return userStore; }
        }

        public static Dictionary<String, User> UserMap
        {
            get { return userMap; }
         }
    }


}
