using Microsoft.AspNetCore.Identity;
using RealEstate2.Models;
using System.Diagnostics;

namespace RealEstate2.Servives
{
    public class SecurityService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
  
        private readonly RoleManager<IdentityRole> _roleManager;
        public SecurityService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager ?? throw new ArgumentNullException();
            _signInManager = signInManager ?? throw new ArgumentNullException();
            _roleManager = roleManager ?? throw new ArgumentNullException();
        }

        public async Task<IdentityUser> Resgiter(IdentityUser s, string password)
        {
            if (s == null)
            {
                throw new ArgumentException(nameof(s));
            }

           

            var result = await _userManager.CreateAsync(s,password);
            if(result.Succeeded)
            {
               
          
                return s;
            }
            

            return null;
           
        }
        public async Task<SignInResult> Login(string username, string password)
        {
        
            
                  var result = await _signInManager.PasswordSignInAsync(username, password, false, lockoutOnFailure: false);



                     return result;
      
            
        }   
    }
}
