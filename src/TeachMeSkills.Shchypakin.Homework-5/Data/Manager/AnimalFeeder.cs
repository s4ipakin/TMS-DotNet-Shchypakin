using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Shchypakin.Homework_5.Data.Manager
{
    public class AnimalFeeder
    {
        public void FeedAnimals()
        {
            Console.WriteLine("It's time to feed the animals! Do you want to fead them all?");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {              
                Feed(FeedAll);
            }
            else
            {
                Console.WriteLine("Choose an animal");
                AnimalBase.AllAnimals.Keys.ToList().ForEach(x => Console.WriteLine(x));
                string userInput = Console.ReadLine();
                if (AnimalBase.AllAnimals.ContainsKey(userInput))
                {
                    Feed(FeedOne, userInput);
                }
                else
                {
                    Console.WriteLine("There is no animal in the zoo with such a name");
                }
            }

            
        }


        private void Feed(Feeding feading, string name = "")
        {
            Console.WriteLine("Choose food: Meat, Herb, Serial");
            string userInput = Console.ReadLine();
            if (Food.TryParse(userInput, out Food food))
            {
                feading(food, name);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }

        private void FeedAll(Food food, string name)
        {
            AnimalBase.AllAnimals.Values.ToList().ForEach(x => x.Eat(food));
        }

        private void FeedOne(Food food, string name)
        {
            AnimalBase.AllAnimals[name].Eat(food);
        }

        private delegate void Feeding(Food food, string name = "");
    }
}
