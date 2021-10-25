using System.Collections.Generic;

namespace TeachMeSkills.Shchypakin.Homework_6.Data
{
    public interface IJson
    {
        public IEnumerable<T> LoadJson<T>(string address);

        public void SaveJson(string filePath, object o);

        public T LoadOneJson<T>(string address);
    }
}