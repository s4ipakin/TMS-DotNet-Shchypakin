using System;
using TeachMeSkills.Shchypakin.Homework_6.Manader;

namespace TeachMeSkills.Shchypakin.Homework_6.UI.KeyOperations
{
    public class KeyOperationP : KeyOperationBase
    {
        public override ConsoleKey Key => ConsoleKey.P;

        /// <summary>
        /// Execute operation for Key P
        /// </summary>
        /// <param name="atm"></param>
        /// <returns></returns>
        public override bool KeyOperation(AtmOperate atm)
        {
            PutGetMoney.PutGet(atm.PutMoney);
            return false;
        }
    }
}