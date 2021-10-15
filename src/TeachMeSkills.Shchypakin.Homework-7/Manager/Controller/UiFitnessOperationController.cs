using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_6.Data;
using TeachMeSkills.Shchypakin.Homework_6.Manader.Json;
using TeachMeSkills.Shchypakin.Homework_7.Data;

namespace TeachMeSkills.Shchypakin.Homework_7.Manager.Controller
{
    public class UiFitnessOperationController 
    {
        private GeneralInfo _generalInfo;

        public UiFitnessOperationController()
        {
            _generalInfo = LoadGeralInfo();
        }

        public void SaveToJsonWithГniqueName(object o)
        {
            
            IJson jsonHandler = new JsonHandler();
            _generalInfo.LastFitnessRoutineId++;
            string infoPath = Directory.GetCurrentDirectory() + "\\" + "General info" + ".json";
            jsonHandler.SaveJson(infoPath, _generalInfo);
            string guid = Guid.NewGuid().ToString().ToUpper().Substring(0, 5);
            string fileName = Directory.GetCurrentDirectory() + "\\" + _generalInfo.LastFitnessRoutineId.ToString() + ".json";
            jsonHandler.SaveJson(fileName, o);
        }

        public void ReadStatistic()
        {
            int count = _generalInfo.LastFitnessRoutineId;
            string startAddress = Directory.GetCurrentDirectory() + "\\";
            List<WorkOutRoutine> results = LoadStatistic(startAddress, count).ToList();
            double weightLoss = results.First().WeightAfter - results.Last().WeightAfter;
            Console.WriteLine();
            Console.WriteLine($"Total weight loss is {weightLoss}" );
        }

        private IEnumerable<WorkOutRoutine> LoadStatistic(string startAddress, int count)
        {
            IJson jsonHandler = new JsonHandler();
            if (count > 0)
            {
                int i = 1;
                string address = startAddress + i.ToString() + ".json";
                WorkOutRoutine routine = new WorkOutRoutine();               
                while (i <= count + 1)
                {
                    if (File.Exists(address))
                    {
                        routine = jsonHandler.LoadOneJson<WorkOutRoutine>(address);                       
                        address = startAddress + i.ToString() + ".json";
                        i++;
                        //Console.WriteLine(routine.WeightAfter.ToString());
                        yield return routine;
                    }
                    else
                    {
                        address = startAddress + i.ToString() + ".json";
                        i++;
                    }
                }
            }
        }

        private GeneralInfo LoadGeralInfo()
        {
            string path = Directory.GetCurrentDirectory() + "\\" + "General info" + ".json";
            IJson jsonHandler = new JsonHandler();
            if (File.Exists(path))
            {
                return jsonHandler.LoadOneJson<GeneralInfo>(path);
            }
            return new GeneralInfo();
        }
    }
}
