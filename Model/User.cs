using FitnessTrackerApp.Enumeration;
using System;

namespace FitnessTrackerApp.Model
{
    public class User
    {
        public string Name { get; set; }
        public DateTime DateofBirth { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Gender Gender { get; set; }
        public decimal Height { get; set; }

    }
}
