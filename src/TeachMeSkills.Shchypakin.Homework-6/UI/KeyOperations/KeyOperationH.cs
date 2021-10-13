using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_6.Manader;

namespace TeachMeSkills.Shchypakin.Homework_6.UI.KeyOperations
{
    public class KeyOperationH : KeyOperationBase
    {
        public override ConsoleKey Key => ConsoleKey.H;

        public override bool KeyOperation(AtmOperate atm)
        {
            Console.WriteLine();
            atm.CheckBalance();
            return false;
        }
    }
}
