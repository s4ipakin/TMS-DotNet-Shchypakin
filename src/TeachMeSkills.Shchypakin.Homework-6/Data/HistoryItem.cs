using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Shchypakin.Homework_6.Data
{
    class HistoryItem
    {
        public DateTime Time { get; set; }

        public OperationType Type { get; set; }

        public decimal Sum { get; set; }

        public decimal AccauntBalance { get; set; }
    }
}
