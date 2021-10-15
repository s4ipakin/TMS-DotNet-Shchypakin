using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_6.Data;
using TeachMeSkills.Shchypakin.Homework_6.Manader.Json;
using TeachMeSkills.Shchypakin.Homework_7.Manager.Controller;
using TeachMeSkills.Shchypakin.Homework_7.Manager.Operations;

namespace TeachMeSkills.Shchypakin.Homework_7.Manager
{
    public class ConsoleUi<T>
    {
        private static Dictionary<ConsoleKey, KeyOperationBase<T>> _keyOperations = new Dictionary<ConsoleKey, KeyOperationBase<T>>();
        private T _operationsController;

        public ConsoleUi(T operationsController)
        {
            _operationsController = operationsController;
            var allKeyoperations = Assembly.GetAssembly(typeof(KeyOperationBase<T>)).GetTypes()
                .Where(t => typeof(KeyOperationBase<T>).IsAssignableFrom(t) && t.IsAbstract == false);

            foreach (var operation in allKeyoperations)
            {
                KeyOperationBase<T> keyOperation = Activator.CreateInstance(operation) as KeyOperationBase<T>;
                _keyOperations.Add(keyOperation.Key, keyOperation);
            }
        }

        public void Run()
        {
            bool stop = false;
            
            while (!stop)
            {
                Console.WriteLine("Input a Command");
                Console.WriteLine("Add an exersise result: A");
                ConsoleKey userKey = Console.ReadKey().Key;
                if (_keyOperations.ContainsKey(userKey))
                {
                    stop = _keyOperations[userKey].KeyOperation(_operationsController);
                }
                else
                {
                    Console.WriteLine("Invalid key");
                }
            }
        }
    }

}
