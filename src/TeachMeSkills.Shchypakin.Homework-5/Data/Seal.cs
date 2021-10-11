using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Shchypakin.Homework_5.Data
{
    public class Seal : PreditorBase
    {
        public Seal(string name) : base(name) { }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is quacking");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} is crawling");
        }
    }
}
