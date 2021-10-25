using System;
using TeachMeSkills.Shchypakin.Homework_6.Manader;

namespace TeachMeSkills.Shchypakin.Homework_6.UI.KeyOperations
{
    public class KeyOperationH : KeyOperationBase
    {
        public override ConsoleKey Key => ConsoleKey.H;

        /// <summary>
        /// Execute operation for Key H
        /// </summary>
        /// <param name="atm"></param>
        /// <returns></returns>
        public override bool KeyOperation(AtmOperate atm)
        {
            Console.WriteLine();
            atm.CheckBalance();
            return false;
        }
    }
}