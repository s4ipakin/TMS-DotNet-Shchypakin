using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_6.Manader;
using TeachMeSkills.Shchypakin.Homework_6.Manader.Json;

namespace TeachMeSkills.Shchypakin.Homework_6.UI
{
    public class AtmUi
    {
        private AtmOperate _atm;
        private JsonHandler _jsonHandler;
        private MoneyDealer _dealer;

        public AtmUi()
        {
            _atm = new AtmOperate();
            _jsonHandler = new JsonHandler();
            _dealer = new MoneyDealer(_atm, _jsonHandler);
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
                switch(Console.ReadKey().Key)
                {
                    case ConsoleKey.P:
                        PutGetMoney(_atm.PutMoney);
                        break;

                    case ConsoleKey.W:
                        PutGetMoney(_atm.GetMoney);
                        break;

                    case ConsoleKey.H:
                        Console.WriteLine();
                        _atm.CheckBalance();
                        break;
                    case ConsoleKey.E:
                        stop = true;
                        break;
                }
            }
        }

        private void PutGetMoney(Action<decimal> operation)
        {
            Console.WriteLine();
            Console.WriteLine("Input sum");
            string userInput = Console.ReadLine();
            if (decimal.TryParse(userInput, out decimal sum))
            {
                operation(sum);
                Console.WriteLine("Operation successful");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
