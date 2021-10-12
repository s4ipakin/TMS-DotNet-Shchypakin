using System;
using TeachMeSkills.Shchypakin.Homework_6.Data;

namespace TeachMeSkills.Shchypakin.Homework_6.Manader
{
    public class AtmOperate : IAccaunt
    {
        public event Action<decimal, OperationType> OperationOccured;

        public event Action BalanceInfoRequired;

        public void PutMoney(decimal sum)
        {
            if (sum < 0)
            {
                sum = sum * -1;
            }

            OperationOccured?.Invoke(sum, OperationType.Receipt);
        }

        public void GetMoney(decimal sum)
        {
            if (sum > 0)
            {
                sum = sum * -1;
            }

            OperationOccured?.Invoke(sum, OperationType.Withdraw);
        }

        public void CheckBalance()
        {
            BalanceInfoRequired?.Invoke();
        }
    }
}