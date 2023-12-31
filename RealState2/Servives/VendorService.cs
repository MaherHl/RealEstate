using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RealEstate2.Models;
using RealEstate2.Servives.Interfaces;
using RealState2.Data;

namespace RealEstate2.Servives
{
    public class VendorService : IVendorService
    {
        private readonly RealEstateDbContext _RealEstatedbContext;
        private readonly UserManager<Vendor> _userManager;
        private readonly SignInManager<Vendor> _signInManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public VendorService(RealEstateDbContext dbContext)
        {
            _RealEstatedbContext = dbContext;
        }

        public VendorService(UserManager<Vendor> userManager, SignInManager<Vendor> signInManager, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<bool> SignIn(string email, string password, bool isPersistent, bool lockoutOnFailure)
        {
            var result = await _signInManager.PasswordSignInAsync(email, password, isPersistent, lockoutOnFailure);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByEmailAsync(email);
                var httpContext = _httpContextAccessor.HttpContext;
                if (httpContext != null)
                {

                    httpContext.Session.SetString("UserId", user._Id.ToString());
                }

            return result.Succeeded;
               
            }
            {
                throw new ApplicationException($"Failed to register vendor. Errors: {string.Join(", ", result.Errors)}");
            }
        }
        public async Task<Vendor> Register(Vendor v, string password)
        {
            if (v == null)
            {
                throw new ArgumentException(nameof(v));
            }
            var newUser = new Vendor
            {
                UserName = v.Email,
                Email = v.Email,
                Firstname = v.Firstname,
                LastName = v.LastName,
                Phone = v.Phone
              
            };
            var result = await _userManager.CreateAsync(newUser, password);
            if (result.Succeeded)
            {
                var httpContext = _httpContextAccessor.HttpContext;
                if (httpContext != null)
                {
                    
                    httpContext.Session.SetString("UserId", newUser._Id.ToString());
                }

                return newUser;
            }
            {
                
                throw new ApplicationException($"Failed to register vendor. Errors: {string.Join(", ", result.Errors)}");
            }
        }

        public async Task<Vendor> DeleteVendor(int Id)
        {
            try
            {
                var vendorToDelete = await _RealEstatedbContext.Vendors.FirstAsync(vendor => vendor._Id == Id);
                if(vendorToDelete == null) {
                    Console.WriteLine("vendor doesn't exist ");
                    return null;
                }
                else

                {
                     _RealEstatedbContext.Vendors.Remove(vendorToDelete);
                     await _RealEstatedbContext.SaveChangesAsync();
                    return vendorToDelete;

                }

            }
            catch(Exception ex) {
                Console.WriteLine($"An Error Occurred while Deleting the vendor:{ex.Message}");
                throw;
            }
        }

        public List<Vendor> GetAll()
        {
            var vendors = _RealEstatedbContext.Vendors.ToList();
            return vendors;
        }

      

        public async  Task<Vendor> GetVendorByID(int Id)
           
        {
           
            
                var vendors = await _RealEstatedbContext.Vendors.FirstAsync(vendor => vendor._Id == Id);
            return vendors;
            
          
        }

        public async Task<Vendor> UpdateVendor(Vendor v)
        {
            try
            {
                 _RealEstatedbContext.Vendors.Update(v);
                await _RealEstatedbContext.SaveChangesAsync();
                return v;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while updating the client: {ex.Message}");
                throw;
            }
        }

        public async Task<bool> VendorExists(int Id)
        {
          
            var vendor = await _RealEstatedbContext.Vendors.FirstAsync(vendor => vendor._Id == Id);
            if (vendor!= null)
            {
                return true;
            }
            else return false;
        }
    }
}
