using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_8.DTO;
using TeachMeSkills.Shchypakin.Homework_8.Entities;

namespace TeachMeSkills.Shchypakin.Homework_8.Interfaces
{
    public interface IClientRepository
    {
        void Update(Client client);

        Task<bool> SaveAllAsync();

        Task<IEnumerable<Client>> GetClientsAsync();

        Task<Client> GetClientByIdAsync(int id);

        Task<Client> GetClientByClientNameAsync(string clientName);

        Task<MemberDto> GetMemberAsync(string clientname);

        Task<IEnumerable<MemberDto>> GetMembersAsync();

    }
}
