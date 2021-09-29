using System;
using System.Collections.Generic;

namespace TeachMeSkills.Shchypakin.Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a day of week please..");
            ReadAndPrint();
        }



        static void ReadAndPrint()
        {
            string userInput = Console.ReadLine();
            if (DayOfWeek.TryParse(userInput, out DayOfWeek day))
            {
                PrintDays(GetDays(day));
            }
            else
            {
                Console.WriteLine("Incorrect day of week");
            }
        }


        static void PrintDays(IEnumerable<DateTime> days)
        {
            foreach (DateTime day in days)
            {
                Console.WriteLine(day.Day);
            }
        }


        static IEnumerable<DateTime> GetDays(DayOfWeek dayOfWeek)
        {
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;
            int nomberOfDays = DateTime.DaysInMonth(currentYear, currentMonth);
            for (int i = 1; i < nomberOfDays + 1; i++)
            {
                DateTime day = new DateTime(currentYear, currentMonth, i);
                if (day.DayOfWeek == dayOfWeek)
                {
                    yield return day;
                }
            }
        }      
    }
}
