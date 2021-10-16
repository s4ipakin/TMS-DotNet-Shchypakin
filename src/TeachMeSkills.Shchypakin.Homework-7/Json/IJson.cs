using System.Collections.Generic;

namespace TeachMeSkills.Shchypakin.Homework_6.Data
{
    public interface IJson
    {
        /// <summary>
        /// Returns an IEumerable of deserialized object in one file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="address"></param>
        /// <returns></returns>
        public IEnumerable<T> LoadJson<T>(string address);

        /// <summary>
        /// Serializes an object to a JSON file
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="o"></param>
        public void SaveJson(string filePath, object o);

        /// <summary>
        /// Deserializes an object from a JSON file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="address"></param>
        /// <returns></returns>
        public T LoadOneJson<T>(string address);
    }
}