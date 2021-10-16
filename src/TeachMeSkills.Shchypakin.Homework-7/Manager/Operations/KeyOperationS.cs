using System;
using TeachMeSkills.Shchypakin.Homework_7.Manager.Controller;

namespace TeachMeSkills.Shchypakin.Homework_7.Manager.Operations
{
    // <summary>
    /// Contains the method that corresponds to the key
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class KeyOperationS : KeyOperationBase<UiFitnessOperationController>
    {
        /// <summary>
        /// Gets the ConsoleKey that triggers the operation
        /// </summary>
        public override ConsoleKey Key => ConsoleKey.S;

        /// <summary>
        /// The operation that is performed after pressing the key
        /// </summary>
        /// <param name="operationController"></param>
        /// <returns></returns>
        public override bool KeyOperation(UiFitnessOperationController operationsController)
        {
            operationsController.ReadStatisticAsync();
            return false;
        }
    }
}