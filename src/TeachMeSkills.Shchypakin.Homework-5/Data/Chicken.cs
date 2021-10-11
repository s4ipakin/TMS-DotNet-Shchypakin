using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Shchypakin.Homework_5.Data
{
    public class Chicken : BirdBase, IEscapable
    {
        public Chicken(string name) : base(name) { }

        public void Escape()
        {
            Move();
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is peeping");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} is running");
        }
    }
}
