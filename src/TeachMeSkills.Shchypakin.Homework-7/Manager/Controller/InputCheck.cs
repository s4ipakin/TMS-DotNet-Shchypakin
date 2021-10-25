using System;

namespace TeachMeSkills.Shchypakin.Homework_7.Manager.Controller
{
    public static class InputCheck
    {
        /// <summary>
        /// Tries to parse a user input into a number
        /// </summary>
        /// <param name="input"></param>
        /// <param name="prop"></param>
        /// <returns></returns>
        public static bool TryTakeInput(string input, out int prop)
        {
            Console.WriteLine(input);
            if (int.TryParse(Console.ReadLine(), out int nomber))
            {
                prop = nomber;
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input");
                prop = default;
                return false;
            }
        }

        /// <summary>
        /// Tries to parse a user input into a number
        /// </summary>
        /// <param name="input"></param>
        /// <param name="prop"></param>
        /// <returns></returns>
        public static bool TryTakeInput(string input, out double prop)
        {
            Console.WriteLine(input);
            if (double.TryParse(Console.ReadLine(), out double nomber))
            {
                prop = nomber;
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input");
                prop = default;
                return false;
            }
        }
    }
}