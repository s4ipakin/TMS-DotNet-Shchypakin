using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Shchypakin.Homework_5.Data
{
    public class Chicken : BirdBase, IEscapable
    {
        /// <summary>
        /// Chicken constructor
        /// </summary>
        /// <param name="name"></param>
        public Chicken(string name) : base(name) { }
        /// <summary>
        /// Make a chicken escape
        /// </summary>
        public void Escape()
        {
            Move();
        }
        /// <summary>
        /// Make a chicken to make a sound
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is peeping");
        }
        /// <summary>
        /// Make a chicken move
        /// </summary>
        public override void Move()
        {
            Console.WriteLine($"{Name} is running");
        }
    }
}
