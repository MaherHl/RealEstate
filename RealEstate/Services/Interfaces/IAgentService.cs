using RealEstate.Models;

namespace RealEstate.Services.Interfaces
{
    public interface IAgentService
    {
        public  Task<Agent> SignUp(Agent agent, string password);
        public  Task<Agent> SignIn(string email, string password);
        public string generateToken(Agent ag );

    }
}
