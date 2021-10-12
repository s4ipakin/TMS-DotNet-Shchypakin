using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_6.Data;

namespace TeachMeSkills.Shchypakin.Homework_6.Manader.Json
{
    public class JsonHandler : IJson
    {
        public IEnumerable<T> LoadJson<T>(string address)
        {
            using (StreamReader r = new StreamReader(address))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<IEnumerable<T>>(json);
            }
        }

        

        public void SaveJson(string filePath, object o)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;
            using (StreamWriter sw = new StreamWriter(filePath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, o);
            }
        }

        public T LoadOneJson<T>(string address)
        {
            using (StreamReader r = new StreamReader(address))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(json);
            }
        }
    }
}
