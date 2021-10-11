using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Shchypakin.Homework_5.Data
{
    public class Elephant : HerbivorousBase, IEscapable
    {
        /// <summary>
        /// Elrphant constructor
        /// </summary>
        /// <param name="name"></param>
        public Elephant(string name) : base(name) { }
        /// <summary>
        /// Make an elephant escape
        /// </summary>
        public void Escape()
        {
            Move();
        }
        /// <summary>
        /// Make an elephant make a sound
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is trumpeting");
        }
        /// <summary>
        /// Make an elephant move
        /// </summary>
        public override void Move()
        {
            Console.WriteLine($"{Name} is walking");
        }
    }
}
