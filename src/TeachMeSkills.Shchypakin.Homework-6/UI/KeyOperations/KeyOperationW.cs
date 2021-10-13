using System;
using TeachMeSkills.Shchypakin.Homework_6.Manader;

namespace TeachMeSkills.Shchypakin.Homework_6.UI.KeyOperations
{
    public class KeyOperationW : KeyOperationBase
    {
        public override ConsoleKey Key => ConsoleKey.W;

        /// <summary>
        /// Execute operation for Key W
        /// </summary>
        /// <param name="atm"></param>
        /// <returns></returns>
        public override bool KeyOperation(AtmOperate atm)
        {
            PutGetMoney.PutGet(atm.GetMoney);
            return false;
        }
    }
}