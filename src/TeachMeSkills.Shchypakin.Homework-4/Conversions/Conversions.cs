using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_4.Data;

namespace TeachMeSkills.Shchypakin.Homework_4
{
    public class Conversions
    {
        // <summary>
        /// Convert status.
        /// </summary>
        /// <param name="status">Before converted.</param>
        /// <returns>After converted.</returns>
        public static JobTaskStatus ConvertStatus(string status)
        {          
            if (status == null)
            {
                throw new System.ArgumentException("Parametr cannot be null", "status");
            }
            return status switch
            {
                "Backlog" => JobTaskStatus.Backlog,
                "InProgress" => JobTaskStatus.InProgress,
                "Done" => JobTaskStatus.Done,
                "Canceled" => JobTaskStatus.Canceled,
                _ => JobTaskStatus.Unknown,
            };
        }
    }
}
