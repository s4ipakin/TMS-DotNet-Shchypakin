using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using TeachMeSkills.Shchypakin.Homework_6.Data;

namespace TeachMeSkills.Shchypakin.Homework_6.Manader.Json
{
    public class JsonHandler : IJson
    {
        /// <summary>
        /// Deserialise a collection from JSON
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="address"></param>
        /// <returns></returns>
        public IEnumerable<T> LoadJson<T>(string address)
        {
            using (StreamReader r = new StreamReader(address))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<IEnumerable<T>>(json);
            }
        }

        /// <summary>
        /// Serialise an object as JSON
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="o"></param>
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

        /// <summary>
        /// Deserialise an object from JSON
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="address"></param>
        /// <returns></returns>
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