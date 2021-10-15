using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_6.Data;
using TeachMeSkills.Shchypakin.Homework_6.Manader.Json;

namespace TeachMeSkills.Shchypakin.Homework_7.Manager.Controller
{
    public class UiFitnessOperationController 
    {
        public void SaveToJsonWithГniqueName(object o)
        {
            IJson jsonHandler = new JsonHandler();
            string guid = Guid.NewGuid().ToString().ToUpper().Substring(0, 5);
            string fileName = Directory.GetCurrentDirectory() + "\\" + guid + ".json";
            jsonHandler.SaveJson(fileName, o);
        }
    }
}
