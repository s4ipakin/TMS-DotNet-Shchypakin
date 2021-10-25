using System;

namespace TeachMeSkills.Shchypakin.Homework_6.Data
{
    internal class HistoryItem
    {
        /// <summary>
        /// Time of the operation
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// Type of the operation
        /// </summary>
        public OperationType Type { get; set; }

        /// <summary>
        /// The sum of the operation
        /// </summary>
        public decimal Sum { get; set; }

        /// <summary>
        /// Current balance after executing the operation
        /// </summary>
        public decimal AccauntBalance { get; set; }
    }
}