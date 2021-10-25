using System;

namespace TeachMeSkills.Shchypakin.Homework_6.Data
{
    public interface IAccaunt
    {
        public event Action<decimal, OperationType> OperationOccured;

        public event Action BalanceInfoRequired;
    }
}