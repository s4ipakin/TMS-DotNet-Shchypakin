using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_6.Data;

namespace TeachMeSkills.Shchypakin.Homework_6.Manader
{
    public class MoneyDealer
    {
        private IJson _jsonHandler;
        private Balance _balance;
        private string _balancePath = @"D:\balance.json";
        private string _historyPath = @"D:\historyRecord";

        public MoneyDealer(IAccaunt accaunt, IJson jsonHandler)
        {
            accaunt.OperationOccured += Accaunt_OperationOccured;
            accaunt.BalanceInfoRequired += Accaunt_BalanceInfoRequired;
            _jsonHandler = jsonHandler;
            _balance = LoadBalance();
        }

        private void Accaunt_BalanceInfoRequired()
        {
            GetHistoryAsync();
        }

        private async void GetHistoryAsync()
        {
            await Task.Run(() => ReadHistory());
        }

        private void ReadHistory()
        {
            int count = _balance.LastOperationId;
            Thread.Sleep(10000); 
            if (count > 0)
            {
                string address = @"D:\historyRecord" + count.ToString() + ".json";
                HistoryItem recordItem = new HistoryItem();
                while (count > 0)
                {
                    if (File.Exists(address))
                    {
                        recordItem = _jsonHandler.LoadOneJson<HistoryItem>(address);
                        Console.WriteLine($"Time: {recordItem.Time} ; Oparation type: {recordItem.Type} ; Sum: {recordItem.Sum} ; Current balance: {recordItem.AccauntBalance}");
                        count--;
                        address = @"D:\historyRecord" + count.ToString() + ".json";
                    }
                }
            }
        }

        private void Accaunt_OperationOccured(decimal sum, OperationType type)
        {
            _balance.CurrentBalance += sum;
            _balance.LastOperationId++;
            HistoryItem recordItem = new HistoryItem
            {
                Time = DateTime.Now,
                Type = type,
                Sum = sum,
                AccauntBalance = _balance.CurrentBalance
            };
            _jsonHandler.SaveJson(_balancePath, _balance);
            string newPath = _historyPath + _balance.LastOperationId.ToString() + ".json";
            _jsonHandler.SaveJson(newPath, recordItem);

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
