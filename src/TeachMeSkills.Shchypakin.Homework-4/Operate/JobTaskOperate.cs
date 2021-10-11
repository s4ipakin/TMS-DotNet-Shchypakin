using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_4.Data;

namespace TeachMeSkills.Shchypakin.Homework_4
{
    public class JobTaskOperate
    {
        /// <summary>
        /// Sets a pull of JobTask.
        /// </summary>
        /// 
        /// <returns>After converted.</returns>
        public virtual IEnumerable<JobTask> SetJobTaskPull()
        {
            bool inputStop = false;
            while (!inputStop)
            {
                Console.Write("Enter name: ");
                var name = Console.ReadLine();
                Console.Write("Enter description: ");
                var description = Console.ReadLine();

                var jobTask = new JobTask
                {
                    Name = name,
                    Description = description,
                };

                yield return jobTask;
                inputStop = InputStop();
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Sets statuses.
        /// </summary>
        public virtual void SetJobTaskStatus(IEnumerable<JobTask> jobTasks)
        {
            if (jobTasks == null)
            {
                throw new System.ArgumentException("Parametr cannot be null", "jobTasks");
            }

            bool inputStop = false;
            while (!inputStop)
            {
                Console.Write("Please enter job task Id: ");
                var userInput = Console.ReadLine();
                jobTasks.Where(x => x.Id == userInput.ToUpperInvariant()).ToList().ForEach(x => { SetStatus(x); });
                inputStop = InputStop();
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Shows all Job tasks in the pull.
        /// </summary>
        public virtual void ShowTaskInfo(IEnumerable<JobTask> jobTasks)
        {
            if (jobTasks == null)
            {
                throw new System.ArgumentException("Parametr cannot be null", "jobTasks");
            }

            Console.WriteLine("=======\n");
            jobTasks.ToList().ForEach(x => GetTaskInfo(x));           
        }

        private void GetTaskInfo(JobTask task)
        {
            Console.WriteLine(task.Id);
            Console.WriteLine("---");
            Console.WriteLine($"Name: {task.Name}");
            Console.WriteLine($"Description: {task.Description}");
            Console.WriteLine($"Status: {task.Status}");
            Console.WriteLine($"DateTime: {task.DateTime}");
            Console.WriteLine();
        }

        private bool InputStop()
        {
            Console.Write("Stop? (Press Y/y): ");
            var key = Console.ReadKey().Key;
            Console.WriteLine();
            return key == ConsoleKey.Y;
        }

        private void SetStatus(JobTask task)
        {
            Console.WriteLine("Job task found! Enter new job task status..");
            Console.WriteLine("Availiable statuses: InProgress, Done, Canceled.");
            Console.Write("Enter status: ");
            var newStatus = Console.ReadLine();
            task.Status = Conversions.ConvertStatus(newStatus);
        }


    }
}
