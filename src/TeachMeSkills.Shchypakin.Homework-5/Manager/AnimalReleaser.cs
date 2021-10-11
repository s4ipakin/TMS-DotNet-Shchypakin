using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Shchypakin.Homework_5.Data.Manager
{
    public class AnimalReleaser
    {
        public void ReleaseAnimals()
        {
            Console.WriteLine("Do you want to set the animals free?");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.WriteLine();

                AnimalBase.AllAnimals.Values.OfType<IEscapable>().ToList().ForEach(x => x.Escape());
                
                var animalList = AnimalBase.AllAnimals.Values.ToList() ;
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
