using System;
using TeachMeSkills.Shchypakin.Homework_6.Data;

namespace TeachMeSkills.Shchypakin.Homework_6.Manader
{
    public class AtmOperate : IAccaunt
    {
        /// <summary>
        /// Is throwed when an operation is occured
        /// </summary>
        public event Action<decimal, OperationType> OperationOccured;

        /// <summary>
        /// Is throwed when the balance info is required
        /// </summary>
        public event Action BalanceInfoRequired;

        /// <summary>
        /// Receipt money
        /// </summary>
        /// <param name="sum"></param>
        public void PutMoney(decimal sum)
        {
            if (sum < 0)
            {
                sum = sum * -1;
            }

            OperationOccured?.Invoke(sum, OperationType.Receipt);
        }

        /// <summary>
        /// Withdraw money
        /// </summary>
        /// <param name="sum"></param>
        public void GetMoney(decimal sum)
        {
            if (sum > 0)
            {
                sum = sum * -1;
            }

            OperationOccured?.Invoke(sum, OperationType.Withdraw);
        }

        /// <summary>
        /// Get the whole histoty of the operations
        /// </summary>
        public void CheckBalance()
        {
            BalanceInfoRequired?.Invoke();
        }
    }
}