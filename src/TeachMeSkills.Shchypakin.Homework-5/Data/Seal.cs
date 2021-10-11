using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Shchypakin.Homework_5.Data
{
    public class Seal : PreditorBase
    {
        /// <summary>
        /// Seal constructor
        /// </summary>
        /// <param name="name"></param>
        public Seal(string name) : base(name) { }
        /// <summary>
        /// Make a seal make a sound
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is quacking");
        }
        /// <summary>
        /// make a seal move
        /// </summary>
        public override void Move()
        {
            Console.WriteLine($"{Name} is crawling");
        }
    }
}
