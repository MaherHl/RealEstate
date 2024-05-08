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
        public async Task<bool> Register([FromForm] Agent ag)
        {
            var result = await _agentService.SignUp(ag, ag.Password);
            if (result != null)
            {
                return true;
            }
            else { return false; }
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LogIn([FromForm] LoginRequest lg )
        
       {
            var agent = await _agentService.SignIn(lg.email, lg.password);
            if (agent != null)
            {
                var token = _agentService.generateToken(agent);
                return Ok(new { Token = token, Agent = agent });
            }
            else return BadRequest("smtg is woring");

        }

    


    }



}
