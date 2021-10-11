using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Shchypakin.Homework_5.Data
{
    public class Tiger : PreditorBase, IEscapable
    {
        /// <summary>
        /// Tiger constructor
        /// </summary>
        /// <param name="name"></param>
        public Tiger(string name) : base(name) { }
        /// <summary>
        /// Make a tiger escape
        /// </summary>
        public void Escape()
        {
            Move();
        }
        /// <summary>
        /// Make a tiger make a sound
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is roaring");
        }
        /// <summary>
        /// Make a tiger move
        /// </summary>
        public override void Move()
        {
            Console.WriteLine($"{Name} is running");
        }
    }
}
