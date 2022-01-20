using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeachMeSkills.Shchypakin.Homework_8.Entities
{
    public class MembershipHistory
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int MembershipId { get; set; }
    }
}
