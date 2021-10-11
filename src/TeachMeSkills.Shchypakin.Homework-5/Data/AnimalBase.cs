using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Shchypakin.Homework_5.Data
{
    public abstract class AnimalBase 
    {
        private static List<AnimalBase> allAnimals = new List<AnimalBase>();
        /// <summary>
        /// Animal constructor
        /// </summary>
        /// <param name="name"></param>
        public AnimalBase(string name)
        {
            Name = name;
            allAnimals.Add(this);
            MakeSound();
        }
        
        /// <summary>
        /// Name of the animal
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Used to fead the animal
        /// </summary>
        /// <param name="food"></param>
        public abstract void Eat(Food food);
        /// <summary>
        /// Move an animal
        /// </summary>
        public abstract void Move();
        /// <summary>
        /// Make an animal make a sound
        /// </summary>
        public abstract void MakeSound();
        /// <summary>
        /// Get a collection of all instances of type AnimalBase
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<AnimalBase> GetAllObjects()
        {
            return allAnimals;
        }
    }
}
