using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Shchypakin.Homework_7.Manager.Controller
{
    public static class InputCheck
    {
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
