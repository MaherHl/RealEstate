using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Models;
using RealEstate.Services;
using RealEstate.Services.Interfaces;

namespace RealEstate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentController : ControllerBase

    {
        private readonly IAgentService _agentService;
        public AgentController(IAgentService agentService)
        {
            _agentService = agentService;
        }
        [HttpPost("Register")]
        public async Task<bool> Register(Agent ag, string password)
        {
            var result = await _agentService.SignUp(ag, password);
            if (result != null)
            {
                return true;
            }
            else { return false; }
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LogIn(string email, string password)
        {
            var agent = await _agentService.SignIn(email, password);
            if (agent != null)
            {
                var token = _agentService.generateToken(agent);
                return Ok(token);
            }
            else return BadRequest("smtg is woring");

        }

    


    }



}
