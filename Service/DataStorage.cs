using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using FitnessTrackerApp.Utility;

namespace FitnessTrackerApp.Service
{
    public class DataStorage
    {
        public static void SaveData<T>(List<T> dataList)
        {
            string JSONPath = GetJSONFilePath<T>();
            string jsonData = JsonConvert.SerializeObject(dataList, Formatting.Indented);
            File.WriteAllText(JSONPath, jsonData);
        }

        public static string GetJSONFilePath<T>()
        {
            string typeName = typeof(T).Name;
            string JSONFileName = $"{typeName}.json";
            return Path.Combine(Util.JSON_STORAGE_PATH, JSONFileName);
        }

        public static List<T> LoadData<T>()
        {
            string JSONPath = GetJSONFilePath<T>();
            if (File.Exists(JSONPath))
            {
                string jsonData = File.ReadAllText(JSONPath);
                return JsonConvert.DeserializeObject<List<T>>(jsonData);
            }
            else
            {
                return new List<T>();
            }
        }
    }
}
