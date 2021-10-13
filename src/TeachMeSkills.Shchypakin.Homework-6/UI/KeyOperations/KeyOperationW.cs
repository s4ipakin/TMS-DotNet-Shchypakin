using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_6.Manader;

namespace TeachMeSkills.Shchypakin.Homework_6.UI.KeyOperations
{
    public class KeyOperationW : KeyOperationBase
    {
        public override ConsoleKey Key => ConsoleKey.W;

        public override bool KeyOperation(AtmOperate atm)
        {
            PutGetMoney.PutGet(atm.GetMoney);
            return false;
        }
    }
}
