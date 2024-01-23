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
        private readonly SecurityService _securityService;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public VendorService(RealEstateDbContext dbContext, SecurityService securityService, IHttpContextAccessor httpContextAccessor)
        {
            _RealEstatedbContext = dbContext;
            _securityService = securityService;
            _httpContextAccessor = httpContextAccessor;
        }

        /*        public VendorService(UserManager<Vendor> userManager, SignInManager<Vendor> signInManager, IHttpContextAccessor httpContextAccessor)
                    {
                    _userManager = userManager;
                    _signInManager = signInManager;
                    _httpContextAccessor = httpContextAccessor;
                }*/
        public async Task<Vendor> CreateVendor(Vendor v, string password)
        {
            if (v == null)
            {
                throw new ArgumentException(nameof(v));
              
                    
                };
            if (password == null)
            {
                return null;
            }
            var user = new IdentityUser()
            {
                UserName = v.Email,
                Email = v.Email,
                   


            };
            var resultUser = await _securityService.Resgiter(user, v.Password);
            if (resultUser != null)
            {
                byte[] profilePictureData = null;

                if (v.PictureFile != null && v.PictureFile.Length > 0)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await v.PictureFile.CopyToAsync(memoryStream);
                        profilePictureData = memoryStream.ToArray();
                    }
                }
                var newUser = new Vendor
                {
                    Firstname = v.Firstname,
                    LastName = v.LastName,
                    Phone = v.Phone,

                    ProfilePicture = profilePictureData,
                    UserId = user.Id,
                    Email = v.Email

                };
        
                    await _RealEstatedbContext.Vendors.AddAsync(newUser);
                    _RealEstatedbContext.SaveChanges();
                    return newUser;
                

            }
            return null;
        }

            public async Task<Vendor> DeleteVendor(int Id)
            {
                try
                {
                    var vendorToDelete = await _RealEstatedbContext.Vendors.FirstAsync(vendor => vendor._Id == Id);
                    if (vendorToDelete == null) {
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
                catch (Exception ex) {
                    Console.WriteLine($"An Error Occurred while Deleting the vendor:{ex.Message}");
                    throw;
                }
            }

            public List<Vendor> GetAll()
            {
                var vendors = _RealEstatedbContext.Vendors.ToList();
                return vendors;
            }



            public async Task<Vendor> GetVendorByID(int Id)

            {


                var vendors = await _RealEstatedbContext.Vendors.FirstAsync(vendor => vendor._Id == Id);
                return vendors;


            }

        public async Task<Vendor> Login(string username, string password)
        {
           var user = await _securityService.Login(username, password );
            if (user != null)

            {
                var vendor = await _RealEstatedbContext.Vendors.FirstOrDefaultAsync(vendor => vendor.Email == username);                 if (vendor != null)
                {
                    return vendor;

                }
                else return null;
                
            }
            else return null;
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
            if (vendor != null)
            {
                return true;
            }
            else return false;
        }
    }
}
