using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_8.DTO;
using TeachMeSkills.Shchypakin.Homework_8.Entities;
using TeachMeSkills.Shchypakin.Homework_8.Interfaces;

namespace TeachMeSkills.Shchypakin.Homework_8.Data
{
    public class ClientRepository : IClientRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ClientRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Client> GetClientByClientNameAsync(string clientName)
        {
            return await _context.Users
                .Include(c => c.Memberships)
                .SingleOrDefaultAsync(x => x.Fullname == clientName);
        }

        public async Task<Client> GetClientByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<IEnumerable<Client>> GetClientsAsync()
        {
            return await _context.Users
                .Include(c => c.Memberships)
                .ToListAsync();
        }

        public async Task<MemberDto> GetMemberAsync(string clientname)
        {
            var client = await _context.Users
                .Where(x => x.Fullname == clientname)
                .ProjectTo<MemberDto>(_mapper.ConfigurationProvider)
                .SingleOrDefaultAsync();

            return client;
        }

        public async Task<IEnumerable<MemberDto>> GetMembersAsync()
        {
            
            
            var clients = await _context.Users
                .ProjectTo<MemberDto>(_mapper.ConfigurationProvider)              
                .ToListAsync();

            var clientsToSend = clients.Select(c => new MemberDto
            {
                FullName = c.FullName,
                Phone = c.Phone,
                Birthday = c.Birthday,
                Comment = c.Comment,
                Memberships = c.Memberships.Where(m => m.IsActive == true).ToList()
            });

            return clientsToSend;
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update(Client client)
        {
            _context.Entry(client).State = EntityState.Modified;
        }
    }
}
