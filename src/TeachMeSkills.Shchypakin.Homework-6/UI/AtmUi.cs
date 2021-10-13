using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_6.Manader;
using TeachMeSkills.Shchypakin.Homework_6.Manader.Json;
using TeachMeSkills.Shchypakin.Homework_6.UI.KeyOperations;

namespace TeachMeSkills.Shchypakin.Homework_6.UI
{
    public class AtmUi
    {
        private AtmOperate _atm;
        private JsonHandler _jsonHandler;
        private MoneyDealer _dealer;
        private static Dictionary<ConsoleKey, KeyOperationBase> _keyOperations = new Dictionary<ConsoleKey, KeyOperationBase>();

        public AtmUi()
        {
            _atm = new AtmOperate();
            _jsonHandler = new JsonHandler();
            _dealer = new MoneyDealer(_atm, _jsonHandler);

            var allKeyoperations = Assembly.GetAssembly(typeof(KeyOperationBase)).GetTypes()
                .Where(t => typeof(KeyOperationBase).IsAssignableFrom(t) && t.IsAbstract == false);

            foreach (var operation in allKeyoperations)
            {
                KeyOperationBase keyOperation = Activator.CreateInstance(operation) as KeyOperationBase;
                _keyOperations.Add(keyOperation.Key, keyOperation);
            }
        }

        public void RunAtm()
        {
            bool stop = false;
            while(!stop)
            {
                Console.WriteLine("Choose a command:");
                Console.WriteLine("W: withdraw money");
                Console.WriteLine("P: put money");
                Console.WriteLine("H: get histoty");
                Console.WriteLine("E: exit");
                ConsoleKey userKey = Console.ReadKey().Key;
                if (_keyOperations.ContainsKey(userKey))
                {
                    stop = _keyOperations[userKey].KeyOperation(_atm);
                }
                else
                {
                    Console.WriteLine("Invalid key");
                }
                
                
                
            }
        }

        
    }
}
