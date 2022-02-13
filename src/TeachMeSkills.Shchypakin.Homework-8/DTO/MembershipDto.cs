using System;
using TeachMeSkills.Shchypakin.Homework_8.Entities;

namespace TeachMeSkills.Shchypakin.Homework_8.DTO
{
    public class MembershipDto
    {
        //public int Id { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        //public int MembershipTypeId { get; set; }

        //public int MembershipSizeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        public MembershipSizeDto MembershipSize { get; set; }

        public bool IsActive { get; set; }
    }
}