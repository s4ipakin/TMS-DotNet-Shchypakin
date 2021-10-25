using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TeachMeSkills.Shchypakin.Homework_7.Manager.Operations;

namespace TeachMeSkills.Shchypakin.Homework_7.Manager
{
    /// <summary>
    /// Runs the UI
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ConsoleUi<T>
    {
        private static Dictionary<ConsoleKey, KeyOperationBase<T>> _keyOperations = new Dictionary<ConsoleKey, KeyOperationBase<T>>();
        private T _operationsController;
        private string _headText;

        public ConsoleUi(T operationsController, string headText)
        {
            _operationsController = operationsController;
            _headText = headText;
            var allKeyoperations = Assembly.GetAssembly(typeof(KeyOperationBase<T>)).GetTypes()
                .Where(t => typeof(KeyOperationBase<T>).IsAssignableFrom(t) && t.IsAbstract == false);

            foreach (var operation in allKeyoperations)
            {
                KeyOperationBase<T> keyOperation = Activator.CreateInstance(operation) as KeyOperationBase<T>;
                _keyOperations.Add(keyOperation.Key, keyOperation);
            }
        }

        /// <summary>
        /// Run the UI
        /// </summary>
        public void Run()
        {
            bool stop = false;

            while (!stop)
            {
                Console.WriteLine();
                Console.WriteLine(_headText);
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