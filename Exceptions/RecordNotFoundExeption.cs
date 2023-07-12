using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackerApp.Exceptions
{
    public class RecordNotFoundExeption : Exception
    {
        public RecordNotFoundExeption(string userName)
            : base($"Record for '{userName}' not found.")
        {
        }

        public RecordNotFoundExeption(string userName, Exception innerException)
            : base($"Record for '{userName}' not found.", innerException)
        {
        }
    }
}
