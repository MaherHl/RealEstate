using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.SqlServer.Server;
using RealEstate.Data;
using RealEstate.Models;
using RealEstate.Services.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Numerics;
using System.Security.Claims;
using System.Text;

namespace RealEstate.Services
{
    public class AgentService : IAgentService


    {
        private readonly SecurityService _securityService;
        private readonly RealEstateDbContext _realEstateDbContext;
        private readonly IConfiguration _config;
        public AgentService(SecurityService securityService, RealEstateDbContext realEstateDbContext , IConfiguration config)
        {
            _securityService = securityService;
            _realEstateDbContext = realEstateDbContext;
            _config = config;
        }
        public async Task<Agent> SignUp(Agent agent, string password)
        {
            if (agent == null)
            {
                throw new ArgumentNullException(nameof(agent));
            }

            var user = new IdentityUser()
            {
                UserName = agent.Email,
                Email = agent.Email,
            };

            if (agent.PictureFile != null && agent.PictureFile.Length > 0)
            {
                var uploadsFolder = Path.Combine("wwwroot", "uploads");
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }
                var uniqueFileName = Guid.NewGuid().ToString() + "_" + agent.PictureFile.FileName;
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await agent.PictureFile.CopyToAsync(stream);
                }

                agent.ProfileImagePath = "/uploads/" + uniqueFileName; // Save the path to the database
            }

            var isCreated = await _securityService.Register(user, password);

            if (isCreated)
            {

                var newAgent = new Agent
                {
                    Firstname = agent.Firstname,
                    LastName = agent.LastName,
                    Phone = agent.Phone,
                    ProfileImagePath= agent.ProfileImagePath,
                    Email = agent.Email
                };

                _realEstateDbContext.Agents.Add(newAgent);
                await _realEstateDbContext.SaveChangesAsync();
                return newAgent;
            }

            return null; // User registration failed
        }

        public async Task<Agent> SignIn(string email, string password)
        {
                
            var isLoggedIn = await _securityService.login(email, password);
            if (isLoggedIn.Succeeded)
            {
                var agent = await _realEstateDbContext.Agents.FirstOrDefaultAsync(x => x.Email == email);
                

                return agent ;
            }
            else return null;

         }

        public string generateToken(Agent ag )
        {
         var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email , ag.Email),

                new Claim(ClaimTypes.Role , "Admin")
            };
            SecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("jwt:key").Value));
            SigningCredentials signinCred = new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha512Signature);
            var securityToken = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(60),
                issuer: _config.GetSection("jwt:Issuer").Value,
                audience:_config.GetSection("jwt:Audience").Value,
                signingCredentials:signinCred
                ) ;
            string token = new JwtSecurityTokenHandler().WriteToken(securityToken);
            return token;
        }
    }

}


