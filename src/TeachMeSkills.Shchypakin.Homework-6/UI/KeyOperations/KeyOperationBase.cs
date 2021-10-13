using System;
using TeachMeSkills.Shchypakin.Homework_6.Manader;

namespace TeachMeSkills.Shchypakin.Homework_6.UI.KeyOperations
{
    public abstract class KeyOperationBase
    {
        public abstract ConsoleKey Key { get; }

        public abstract bool KeyOperation(AtmOperate atm);
    }
}