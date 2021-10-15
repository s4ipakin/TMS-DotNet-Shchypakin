using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_7.Manager.Controller;

namespace TeachMeSkills.Shchypakin.Homework_7.Manager.Operations
{
    public class KeyOperationE : KeyOperationBase<UiFitnessOperationController>
    {
        public override ConsoleKey Key => ConsoleKey.E;

        public override bool KeyOperation(UiFitnessOperationController operationsController)
        {
            return true;
        }
    }
}
