using System;
using System.Collections.Generic;
using TeachMeSkills.Shchypakin.Homework_4.Data;
using System.Linq;

namespace TeachMeSkills.Shchypakin.Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<JobTask> jobTaskList = new List<JobTask>();
            JobTaskOperate jobTaskOperate = new JobTaskOperate();

            jobTaskList = jobTaskOperate.SetJobTaskPull().ToList();
            jobTaskOperate.ShowTaskInfo(jobTaskList);
            jobTaskOperate.SetJobTaskStatus(jobTaskList);
            jobTaskOperate.ShowTaskInfo(jobTaskList);

            Console.ReadLine();
        }
    }
}
