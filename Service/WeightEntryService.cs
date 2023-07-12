using System.Collections.Generic;
using System.Linq;
using FitnessTrackerApp.Exceptions;
using FitnessTrackerApp.Model;

namespace FitnessTrackerApp.Service
{
    public class WeightEntryService
    {
        private static WeightEntryService instance;
        private static readonly object lockObject = new object();

        public static WeightEntryService Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new WeightEntryService();
                        }
                    }
                }
                return instance;
            }
        }

        public List<WeightEntry> FindWeightEntriesInAscByUserName(string UserName)
        {
            return (List<WeightEntry>) GetWeightEntries().Where(obj => obj.UserName.Equals(UserName)).OrderBy(obj => obj.Date);
        }

        public List<WeightEntry> FindUFindWeightEntriesInDescByUserName(string UserName)
        {
            return (List<WeightEntry>) GetWeightEntries().Where(obj => obj.UserName.Equals(UserName)).OrderByDescending(obj => obj.Date);
        }

        public WeightEntry GetWeightEntryByGUID(List<WeightEntry> WeightEntries, string GUID)
        {
            return WeightEntries.FirstOrDefault(obj => obj.GUID.Equals(GUID));
        }

        public WeightEntry AddEntry(WeightEntry WeightEntry)
        {
            List<WeightEntry> WeightEntries = GetWeightEntries();
            WeightEntry.GUID = System.Guid.NewGuid().ToString();
            WeightEntries.Add(WeightEntry);
            DataStorage.SaveData(WeightEntries);

            return WeightEntry;
        }

        public void DeleteEntry(string GUID)
        {
            List<WeightEntry> WeightEntries = GetWeightEntries();
            var WeightEntry = GetWeightEntryByGUID(WeightEntries, GUID);
            if (WeightEntry != null)
            {
                WeightEntries.Remove(WeightEntry);
                DataStorage.SaveData(WeightEntries);
            } 
            else
            {
                throw new RecordNotFoundExeption(GUID);
            }
            
        }

        public WeightEntry UpdateUser(WeightEntry Entry)
        {
            List<WeightEntry> WeightEntries = GetWeightEntries();
            var WeightEntry = GetWeightEntryByGUID(WeightEntries, Entry.GUID);
            if (WeightEntry != null)
            {
                WeightEntry.Weight = Entry.Weight;
                WeightEntry.Date = Entry.Date;
                DataStorage.SaveData(WeightEntries);
            }
            else
            {
                throw new RecordNotFoundExeption(Entry.GUID);
            }
            return Entry;
        }

        public static List<WeightEntry> GetWeightEntries()
        {
            return DataStorage.LoadData<WeightEntry>();
        }

    }
}
