using System;

namespace TeachMeSkills.Shchypakin.Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input a date please..");
            string userInput = Console.ReadLine();

            if (DateTime.TryParse(userInput, out DateTime date))
            {
                Console.WriteLine("The day of week is {0}", date.DayOfWeek);
            }
            else
            {
                Console.WriteLine("Incorrect date");
            }
        }
    }
}
