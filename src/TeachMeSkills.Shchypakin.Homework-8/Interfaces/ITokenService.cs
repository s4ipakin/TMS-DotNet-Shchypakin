using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_8.Entities;

namespace TeachMeSkills.Shchypakin.Homework_8.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(Client client);
    }
}
