using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RealEstate2.Models;
using RealEstate2.Servives;
using RealEstate2.Servives.Interfaces;

namespace RealEstate2.Controllers
{
    public class VendorController : Controller
    {
        private readonly IVendorService _vendorService;
        public VendorController(IVendorService vendorService)
        {
            _vendorService = vendorService ?? throw new ArgumentNullException(nameof(vendorService));
        }
        [HttpPost]
        [Route("/Vendor/SignUp")]
        public async Task<IActionResult> SignUp([FromForm] Vendor v, string password)
        {

            await _vendorService.CreateVendor(v, password);





            return View();

        }
   
        [Route("/Vendor/SignUp")]
        public async Task<IActionResult> SignUp()
        { 
            return View();
        }

        [Route("/Vendor/SignIn")]
       public async Task<IActionResult> SignIn([FromForm]string Email, string password)
        {
            bool result = await _vendorService.Login(Email, password);
            if(result == true)
            {
                return View();
            }
            else
            {
                return View("NotFound");
            }
        }
    }
}