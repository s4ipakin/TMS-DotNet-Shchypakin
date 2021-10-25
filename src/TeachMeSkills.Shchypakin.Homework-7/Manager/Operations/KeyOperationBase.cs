using System;

namespace TeachMeSkills.Shchypakin.Homework_7.Manager.Operations
{
    /// <summary>
    /// Contains the method that corresponds to the key
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class KeyOperationBase<T>
    {
        /// <summary>
        /// Gets the ConsoleKey that triggers the operation
        /// </summary>
        public abstract ConsoleKey Key { get; }

        /// <summary>
        /// The operation that is performed after pressing the key
        /// </summary>
        /// <param name="operationController"></param>
        /// <returns></returns>
        public abstract bool KeyOperation(T operationsController);
    }
}