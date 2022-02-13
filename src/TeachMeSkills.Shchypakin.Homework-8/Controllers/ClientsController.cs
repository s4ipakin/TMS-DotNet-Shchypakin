using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeachMeSkills.Shchypakin.Homework_8.Data;
using TeachMeSkills.Shchypakin.Homework_8.DTO;
using TeachMeSkills.Shchypakin.Homework_8.Entities;
using TeachMeSkills.Shchypakin.Homework_8.Enum;
using TeachMeSkills.Shchypakin.Homework_8.Interfaces;

namespace TeachMeSkills.Shchypakin.Homework_8.Controllers
{
    public class ClientsController : BaseApiController
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public ClientsController(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetClients()
        {
            var clients = await _clientRepository.GetMembersAsync();
            return Ok(clients);
        }

        //[Authorize]
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Client>> GetClient(int id)
        //{
        //    return await _clientRepository.GetClientByIdAsync(id);
        //}

        //[Authorize]
        [HttpGet("{clientname}")]
        public async Task<ActionResult<MemberDto>> GetClientByName(string clientname)
        {
            var client = await _clientRepository.GetMemberAsync(clientname);
            return client;
        }
    }
}
