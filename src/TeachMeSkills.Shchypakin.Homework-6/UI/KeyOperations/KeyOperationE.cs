using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_6.Manader;

namespace TeachMeSkills.Shchypakin.Homework_6.UI.KeyOperations
{
    public class KeyOperationE : KeyOperationBase
    {
        public override ConsoleKey Key => ConsoleKey.E;

        public override bool KeyOperation(AtmOperate atm)
        {
            return true;
        }
    }
}
