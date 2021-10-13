using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Shchypakin.Homework_6.UI.KeyOperations
{
    public static class PutGetMoney
    {
        public static void PutGet(Action<decimal> operation)
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
