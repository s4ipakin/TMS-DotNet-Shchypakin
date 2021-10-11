using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Shchypakin.Homework_5.Data
{
    public abstract class PreditorBase : AnimalBase
    {
        public PreditorBase(string name) : base(name) { }
        public override void Eat(Food food)
        {
            if (food == Food.Meat)
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
