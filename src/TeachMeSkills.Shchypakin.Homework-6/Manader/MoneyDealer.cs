using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_6.Data;

namespace TeachMeSkills.Shchypakin.Homework_6.Manader
{
    public class MoneyDealer
    {
        private IJson _jsonHandler;
        private Balance _balance;
        private string _balancePath = @"D:\balance.json";

        public MoneyDealer(IAccaunt accaunt, IJson jsonHandler)
        {
            accaunt.OperationOccured += Accaunt_OperationOccured;
            accaunt.BalanceInfoRequired += Accaunt_BalanceInfoRequired;
            _jsonHandler = jsonHandler;
            _balance = LoadBalance();
        }

        private void Accaunt_BalanceInfoRequired()
        {
            throw new NotImplementedException();
        }

        private void Accaunt_OperationOccured(decimal sum, OperationType type)
        {
            _balance.CurrentBalance += sum;
            _jsonHandler.SaveJson(_balancePath, _balance);
        }

        private Balance LoadBalance()
        {

            if (File.Exists(_balancePath))
            {
                return _jsonHandler.LoadOneJson<Balance>(_balancePath);
            }
            return new Balance();
        }
    }
}
