using Microsoft.AspNetCore.Identity;
using System.Data.SqlTypes;

namespace RealEstate.Services
{
    public class SecurityService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly  SignInManager<IdentityUser> _signInManager;
        public SecurityService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager) {
            _userManager = userManager;
            _signInManager = signInManager;
        
        
        }


        public async Task<bool> Register(IdentityUser agent , string password)
        {
            if (agent == null) throw new ArgumentNullException();
            var result = await _userManager.CreateAsync(agent, password);
            if (result.Succeeded)
            {
                return true;
            }
            else
            {

                return false;
            }

        }
        public async Task<SignInResult> login(string username , string password)
        {
            var  result =  await _signInManager.PasswordSignInAsync( username, password,false,lockoutOnFailure:false);
            
            return result;
        }

    }
}
