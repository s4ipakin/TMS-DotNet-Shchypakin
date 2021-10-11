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
                Console.WriteLine();
                Feed(AnimalBase.AllAnimals, FeedAll);
            }
            else
            {
                bool isInputCorrect = false;
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Choose an animal");
                    AnimalBase.AllAnimals.Keys.ToList().ForEach(x => Console.WriteLine(x));
                    string userInput = Console.ReadLine();
                    if (AnimalBase.AllAnimals.ContainsKey(userInput))
                    {
                        Feed(AnimalBase.AllAnimals, FeedOne, userInput);
                        isInputCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("There is no animal in the zoo with such a name");
                    }
                }
                while (!isInputCorrect);
            }           
        }

        private delegate void Feeding(Dictionary<string, AnimalBase> dictinary, Food food, string name = "");

        private void Feed(Dictionary<string, AnimalBase> dictinary, Feeding feading, string name = "")
        {
            bool isInputCorrect = false;
            do
            {
                Console.WriteLine("Choose food: Meat, Herb, Serial");
                string userInput = Console.ReadLine();
                if (Food.TryParse(userInput, out Food food))
                {
                    feading(dictinary, food, name);
                    isInputCorrect = true;
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            }
            while(!isInputCorrect);
        }

        private void FeedAll(Dictionary<string, AnimalBase> dictinary, Food food, string name)
        {
            dictinary.Values.ToList().ForEach(x => x.Eat(food));
        }

        private void FeedOne(Dictionary<string, AnimalBase> dictinary, Food food, string name)
        {
            
            if (dictinary.TryGetValue(name, out AnimalBase animal))
            {
                animal.Eat(food);
            }
        }
    }
}
