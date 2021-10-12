using System;
using TeachMeSkills.Shchypakin.Homework_6.Manader;
using TeachMeSkills.Shchypakin.Homework_6.Manader.Json;

namespace TeachMeSkills.Shchypakin.Homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            AtmOperate atm = new AtmOperate();
            JsonHandler jsonHandler = new JsonHandler();
            MoneyDealer dealer = new MoneyDealer(atm, jsonHandler);
            string smoneyPut = Console.ReadLine();
            decimal moneyPut = Convert.ToDecimal(smoneyPut);
            atm.PutMoney(moneyPut);
            smoneyPut = Console.ReadLine();
            moneyPut = Convert.ToDecimal(smoneyPut);
            atm.GetMoney(moneyPut);
            if (Console.ReadKey().Key == ConsoleKey.H)
            {
                Console.WriteLine();
                atm.CheckBalance();
            }
            smoneyPut = Console.ReadLine();
            Console.WriteLine(smoneyPut);
            Console.ReadKey();
            Console.ReadKey();

        }
    }
}
