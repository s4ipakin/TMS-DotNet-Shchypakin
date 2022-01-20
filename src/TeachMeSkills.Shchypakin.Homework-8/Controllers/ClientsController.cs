using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_8.Data;
using TeachMeSkills.Shchypakin.Homework_8.Entities;

namespace TeachMeSkills.Shchypakin.Homework_8.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly DataContext _context;

        public ClientsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client>>> GetClients()
        {
            MembershipSize membershipSize = new MembershipSize
            {
                Count = 8
            };

            MembershipType membershipType = new MembershipType
            {
                Type = "Offline"
            };

            Client client1 = new Client
            {
                FirstName = "Jennifer",
                LastName = "Lopez"
            };

            Membership membership1 = new Membership
            {
                ClientId = 2,
                MembershipSizeId = 2,
                MembershipTypeId = 2,
                IsActive = true
            };

            _context.MembershipSizes.Add(membershipSize);
            _context.MembershipTypes.Add(membershipType);
            _context.Clients.Add(client1);
            _context.Memberships.Add(membership1);

            _context.SaveChanges();


            return await _context.Clients.ToListAsync();
        }
    }
}
