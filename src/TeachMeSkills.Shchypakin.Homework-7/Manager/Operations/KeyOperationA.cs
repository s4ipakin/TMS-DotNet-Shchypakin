using System;
using TeachMeSkills.Shchypakin.Homework_7.Data;
using TeachMeSkills.Shchypakin.Homework_7.Manager.Controller;

namespace TeachMeSkills.Shchypakin.Homework_7.Manager.Operations
{
    // <summary>
    /// Contains the method that corresponds to the key
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class KeyOperationA : KeyOperationBase<UiFitnessOperationController>
    {
        /// <summary>
        /// Gets the ConsoleKey that triggers the operation
        /// </summary>
        public override ConsoleKey Key => ConsoleKey.A;

        /// <summary>
        /// The operation that is performed after pressing the key
        /// </summary>
        /// <param name="operationController"></param>
        /// <returns></returns>
        public override bool KeyOperation(UiFitnessOperationController operationController)
        {
            WorkOutRoutine routine = new WorkOutRoutine();
            Console.WriteLine();
            if (!InputCheck.TryTakeInput("Input number of minutes", out int minutes))
            {
                return false;
            }
            else
            {
                routine.Minutes = minutes;
            }

            if (!InputCheck.TryTakeInput("Input your weight after compliting the exercise", out double weight))
            {
                return false;
            }
            else
            {
                routine.WeightAfter = weight;
            }

            if (!InputCheck.TryTakeInput("Input your pulse after exercising", out int pulse))
            {
                return false;
            }
            else
            {
                routine.PulseAfter = pulse;
            }

            Console.WriteLine("Was it anaerobic (Y/N)");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                routine.IsAnaerobic = true;
            }
            else
            {
                routine.IsAnaerobic = false;
            }

            operationController.SaveToJsonWithUniqueName(routine);
            return false;
        }
    }
}