using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_8.DTO;
using TeachMeSkills.Shchypakin.Homework_8.Entities;

namespace TeachMeSkills.Shchypakin.Homework_8.Helpers
{
    public class AutomapperProfiles : Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<Client, MemberDto>();
            CreateMap<Membership, MembershipDto>();
            CreateMap<MembershipSize, MembershipSizeDto>();
            CreateMap<MembershipType, MembershipTypeDto>();
            CreateMap<RegisterDto, Client>();
        }
    }
}
