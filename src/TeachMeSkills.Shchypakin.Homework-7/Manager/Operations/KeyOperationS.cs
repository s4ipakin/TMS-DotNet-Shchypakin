using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_7.Manager.Controller;

namespace TeachMeSkills.Shchypakin.Homework_7.Manager.Operations
{
    public class KeyOperationS : KeyOperationBase<UiFitnessOperationController>
    {
        public override ConsoleKey Key => ConsoleKey.S;

        public override bool KeyOperation(UiFitnessOperationController operationsController)
        {
            operationsController.ReadStatistic();
            return false;
        }
    }
}
