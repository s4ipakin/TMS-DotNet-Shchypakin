using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Shchypakin.Homework_5.Data.Manager
{
    public class AnimalReleaser
    {
        /// <summary>
        /// Let the animals go
        /// </summary>
        public void ReleaseAnimals()
        {
            Dictionary<string, AnimalBase> allAnimals = new Dictionary<string, AnimalBase>();
            AnimalBase.GetAllObjects().ToList().ForEach(x => { allAnimals.TryAdd(x.Name, x); });

            Console.WriteLine("Do you want to set the animals free? (Y/N)");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.WriteLine();

                allAnimals.Values.OfType<IEscapable>().ToList().ForEach(x => x.Escape());
                
                var animalList = allAnimals.Values.ToList() ;
                animalList.RemoveAll(FindUnescapable);
                animalList.ForEach(x => Console.WriteLine($"{x.Name} is staying in the zoo"));
            }          
        }

        private bool FindUnescapable(AnimalBase animal)
        {
            return animal.GetType().GetInterfaces().Contains(typeof(IEscapable));
        }
    }
}
