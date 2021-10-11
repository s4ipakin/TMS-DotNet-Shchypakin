using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Shchypakin.Homework_5.Data
{
    public class Elephant : HerbivorousBase, IEscapable
    {
        public Elephant(string name) : base(name) { }

        public void Escape()
        {
            Move();
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is trumpeting");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} is walking");
        }
    }
}
