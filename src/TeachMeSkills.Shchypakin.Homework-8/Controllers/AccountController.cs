using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_8.Data;
using TeachMeSkills.Shchypakin.Homework_8.DTO;
using TeachMeSkills.Shchypakin.Homework_8.Entities;
using TeachMeSkills.Shchypakin.Homework_8.Interfaces;

namespace TeachMeSkills.Shchypakin.Homework_8.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly DataContext _context;
        private readonly ITokenService _tokenService;

        public AccountController(DataContext context, ITokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }

        [HttpPost("register")]
        public async Task<ActionResult<ClientDto>> Register(RegisterDto registerDto)
        {
            if (await ClientExist(registerDto.ClientName)) return BadRequest("Username is taken");

            using var hmac = new HMACSHA512();

            var client = new Client();

            _context.Add(client);
            await _context.SaveChangesAsync();
            return new ClientDto
            {
                ClientName = registerDto.ClientName,
                Token = _tokenService.CreateToken(client)
            };
        }

        [HttpPost("login")]
        public async Task<ActionResult<ClientDto>> Login(LoginDto loginDto)
        {
            var client = await _context.Users.SingleOrDefaultAsync(x => x.Fullname == loginDto.ClientName);

            if (client == null) return Unauthorized("Invalid user name");

            return new ClientDto
            {
                ClientName = loginDto.ClientName,
                Token = _tokenService.CreateToken(client)
            };
        }


        private async Task<bool> ClientExist(string clientName)
        {
            return await _context.Users.AnyAsync(x => x.Fullname == clientName.ToLower());
        }

    }
}
