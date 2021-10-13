using System;

namespace TeachMeSkills.Shchypakin.Homework_6.UI.KeyOperations
{
    public static class PutGetMoney
    {
        /// <summary>
        /// Universal method for putting or getting money
        /// </summary>
        /// <param name="operation"></param>
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