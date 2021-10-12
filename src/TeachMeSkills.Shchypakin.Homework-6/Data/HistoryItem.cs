using System;

namespace TeachMeSkills.Shchypakin.Homework_6.Data
{
    internal class HistoryItem
    {
        public DateTime Time { get; set; }

        public OperationType Type { get; set; }

        public decimal Sum { get; set; }

        public decimal AccauntBalance { get; set; }
    }
}