using System;
using TeachMeSkills.Shchypakin.Homework_6.Manader;

namespace TeachMeSkills.Shchypakin.Homework_6.UI.KeyOperations
{
    public class KeyOperationE : KeyOperationBase
    {
        public override ConsoleKey Key => ConsoleKey.E;

        /// <summary>
        /// Execute operation for Key E
        /// </summary>
        /// <param name="atm"></param>
        /// <returns></returns>
        public override bool KeyOperation(AtmOperate atm)
        {
            return true;
        }
    }
}