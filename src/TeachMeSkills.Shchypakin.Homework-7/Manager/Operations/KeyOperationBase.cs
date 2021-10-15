using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_6.Data;
using TeachMeSkills.Shchypakin.Homework_7.Data;
using TeachMeSkills.Shchypakin.Homework_7.Manager.Controller;

namespace TeachMeSkills.Shchypakin.Homework_7.Manager.Operations
{
    public abstract class KeyOperationBase<T>
    {
        public abstract ConsoleKey Key { get; }

        public abstract bool KeyOperation(T operationsController);
    }
}
