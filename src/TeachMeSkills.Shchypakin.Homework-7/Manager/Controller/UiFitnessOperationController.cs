using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_6.Data;
using TeachMeSkills.Shchypakin.Homework_6.Manader.Json;
using TeachMeSkills.Shchypakin.Homework_7.Data;

namespace TeachMeSkills.Shchypakin.Homework_7.Manager.Controller
{
    /// <summary>
    /// Contains methods for the UI
    /// </summary>
    public class UiFitnessOperationController
    {
        private GeneralInfo _generalInfo;

        public UiFitnessOperationController()
        {
            _generalInfo = LoadGeralInfo();
        }

        /// <summary>
        /// Saves an object with an incremented number for a name
        /// </summary>
        /// <param name="o"></param>
        public void SaveToJsonWithUniqueName(object o)
        {
            IJson jsonHandler = new JsonHandler();
            _generalInfo.LastFitnessRoutineId++;
            string infoPath = Directory.GetCurrentDirectory() + "\\" + "General info" + ".json";
            jsonHandler.SaveJson(infoPath, _generalInfo);
            string guid = Guid.NewGuid().ToString().ToUpper().Substring(0, 5);
            string fileName = Directory.GetCurrentDirectory() + "\\" + _generalInfo.LastFitnessRoutineId.ToString() + ".json";
            jsonHandler.SaveJson(fileName, o);
        }

        /// <summary>
        /// Shows the statistic data from all the routines
        /// </summary>
        public void ReadStatistic()
        {
            int count = _generalInfo.LastFitnessRoutineId;
            string startAddress = Directory.GetCurrentDirectory() + "\\";
            List<WorkOutRoutine> results = LoadStatistic(startAddress, count).ToList();
            GetTotalWeightLoss(results);
            GetPulseStat(results);
            GetAnaeribicAerobicNumber(results);
            GetTime(results);
        }

        /// <summary>
        /// Shows the statistic data from all the routines asyncronuously
        /// </summary>
        public async void ReadStatisticAsync()
        {
            await Task.Run(() => ReadStatistic());
        }

        private void GetTime(List<WorkOutRoutine> workOutRoutines)
        {
            int maxMinutesNumber = workOutRoutines.Select(x => x.Minutes).Max();
            int minMinutesNumber = workOutRoutines.Select(x => x.Minutes).Min();
            int averageMinutesNumber = Convert.ToInt32(
                workOutRoutines.Select(x => x.Minutes).Average());
            int totalTime = workOutRoutines.Select(x => x.Minutes).Aggregate((a, b) => a + b);
            int anaerobicMinutes = workOutRoutines.Where(x => x.IsAnaerobic == true)
                .Select(x => x.Minutes).Aggregate((a, b) => a + b);
            int aerobicMinutes = workOutRoutines.Where(x => x.IsAnaerobic == false)
                .Select(x => x.Minutes).Aggregate((a, b) => a + b);

            Console.WriteLine($"Maximun exercise duration is {maxMinutesNumber} minutes");
            Console.WriteLine($"Minimun exercise duration is {minMinutesNumber} minutes");
            Console.WriteLine($"Average exercise duration is {averageMinutesNumber} minutes");
            Console.WriteLine($"Total anaerobic exercise duration is {anaerobicMinutes} minutes");
            Console.WriteLine($"Total aerobic exercise duration is {aerobicMinutes} minutes");
            Console.WriteLine($"Total workingout duration is {totalTime} minutes");
        }

        private void GetAnaeribicAerobicNumber(List<WorkOutRoutine> workOutRoutines)
        {
            int anaerobicNumber = workOutRoutines.Where(x => x.IsAnaerobic == true).Count();
            int aerobicNumber = workOutRoutines.Where(x => x.IsAnaerobic == false).Count();
            //Console.WriteLine();
            Console.WriteLine($"Number of anaerobic tranings is {anaerobicNumber}");
            Console.WriteLine($"Number of aerobic tranings is {aerobicNumber}");
        }

        private void GetTotalWeightLoss(List<WorkOutRoutine> workOutRoutines)
        {
            double weightLoss = workOutRoutines.First().WeightAfter - workOutRoutines.Last().WeightAfter;
            var totalWeightLosses = workOutRoutines.Select((w, i) => new
            {
                WeightLoss = i > 0 ? workOutRoutines[i - 1].WeightAfter - w.WeightAfter : 0.0,
                IsAnaerobic = w.IsAnaerobic
            });

            double anaerobicWeightLoss = totalWeightLosses.Where(x => x.IsAnaerobic == true)
                .Select(x => x.WeightLoss).Average();
            double aerobicWeightLoss = totalWeightLosses.Where(x => x.IsAnaerobic == false)
                .Select(x => x.WeightLoss).Average();

            Console.WriteLine($"Average weitght loss after an anaerobic exercise is {anaerobicWeightLoss}");
            Console.WriteLine($"Average weitght loss after an aerobic exercise is {aerobicWeightLoss}");
            Console.WriteLine($"Total weight loss is {weightLoss}");
        }

        private void GetPulseStat(List<WorkOutRoutine> workOutRoutines)
        {
            int maxPulse = workOutRoutines.Select(x => x.PulseAfter).Max();
            int minPulse = workOutRoutines.Select(x => x.PulseAfter).Min();
            int avrgAnaerobicPulse = Convert.ToInt32(workOutRoutines.Where(x => x.IsAnaerobic == true)
                .Select(x => x.PulseAfter).Average());
            int avrgAerobicPulse = Convert.ToInt32(workOutRoutines.Where(x => x.IsAnaerobic == false)
                .Select(x => x.PulseAfter).Average());
            //Console.WriteLine();
            Console.WriteLine($"Maximum pulse was {maxPulse}");
            Console.WriteLine($"Minimum pulse was {minPulse}");
            Console.WriteLine($"Averge anaerobic pulse was {avrgAnaerobicPulse}");
            Console.WriteLine($"Averge aerobic pulse was {avrgAerobicPulse}");
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
                        i++;
                        address = startAddress + i.ToString() + ".json";                        
                        //Console.WriteLine(routine.WeightAfter.ToString());
                        yield return routine;
                    }
                    else
                    {
                        i++;
                        address = startAddress + i.ToString() + ".json";                      
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