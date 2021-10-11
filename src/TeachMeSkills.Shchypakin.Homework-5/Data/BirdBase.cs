using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Shchypakin.Homework_5.Data
{
    public abstract class BirdBase : AnimalBase
    {
        public BirdBase(string name) : base(name) { }
        public override void Eat(Food food)
        {
            if (food == Food.Serial)
            {
                Console.WriteLine($"{Name} is eating");
            }
            else
            {
                Console.WriteLine($"{Name} refuses to eat this");
            }
        }
    }
}
