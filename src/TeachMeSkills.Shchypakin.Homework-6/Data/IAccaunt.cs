using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Shchypakin.Homework_6.Data
{
    public interface IAccaunt
    {
        public event Action<decimal, OperationType> OperationOccured;
        public event Action BalanceInfoRequired;
    }
}
