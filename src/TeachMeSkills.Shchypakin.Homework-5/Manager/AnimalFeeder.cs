using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Shchypakin.Homework_5.Data.Manager
{
    public class AnimalFeeder
    {
        /// <summary>
        /// Feed animals
        /// </summary>
        public void FeedAnimals()
        {
            Dictionary<string, AnimalBase> allAnimals = new Dictionary<string, AnimalBase>();
            AnimalBase.GetAllObjects().ToList().ForEach(x => { allAnimals.TryAdd(x.Name, x); });
            Console.WriteLine("It's time to feed the animals! Do you want to fead them all? (Y/N)");          
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.WriteLine();
                Feed(allAnimals, FeedAll);
            }
            else
            {
                bool isInputCorrect = false;
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Choose an animal");
                    allAnimals.Keys.ToList().ForEach(x => Console.WriteLine(x));
                    string userInput = Console.ReadLine();
                    if (allAnimals.ContainsKey(userInput))
                    {
                        Feed(allAnimals, FeedOne, userInput);
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
            if (dictinary == null)
            {
                throw new System.ArgumentException("Parametr cannot be null", "dictinary");
            }

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
            if (dictinary == null)
            {
                throw new System.ArgumentException("Parametr cannot be null", "dictinary");
            }

            dictinary.Values.ToList().ForEach(x => x.Eat(food));
        }

        private void FeedOne(Dictionary<string, AnimalBase> dictinary, Food food, string name)
        {
            if(dictinary == null)
            {
                throw new System.ArgumentException("Parametr cannot be null", "dictinary");
            }

            if (name == null)
            {
                throw new System.ArgumentException("Parametr cannot be null", "name");
            }

            if (dictinary.TryGetValue(name, out AnimalBase animal))
            {
                animal.Eat(food);
            }
            else
            {
                throw new System.ArgumentException("There is no such key in the dictinary", "name");
            }
        }
    }
}
