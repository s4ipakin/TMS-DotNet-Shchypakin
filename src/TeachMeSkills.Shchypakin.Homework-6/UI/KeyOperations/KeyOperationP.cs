using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_6.Manader;

namespace TeachMeSkills.Shchypakin.Homework_6.UI.KeyOperations
{
    public class KeyOperationP : KeyOperationBase
    {
        public override ConsoleKey Key => ConsoleKey.P;

        public override bool KeyOperation(AtmOperate atm)
        {
            PutGetMoney.PutGet(atm.PutMoney);
            return false;
        }
    }
}
