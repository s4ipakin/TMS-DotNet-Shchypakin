using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Shchypakin.Homework_5.Data
{
    public class Tiger : PreditorBase, IEscapable
    {
        public Tiger(string name) : base(name) { }

        public void Escape()
        {
            Move();
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is roaring");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} is running");
        }
    }
}
