using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Shchypakin.Homework_6.Data
{
    public interface IJson
    {
        public IEnumerable<T> LoadJson<T>(string address);
        public void SaveJson(string filePath, object o);
        public T LoadOneJson<T>(string address);
    }
}
