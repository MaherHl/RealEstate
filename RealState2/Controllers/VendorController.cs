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
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IFacilityService _facilityService;
        public VendorController(IVendorService vendorService, IHttpContextAccessor contextAccessor,IFacilityService facilityService)
        {
            _vendorService = vendorService ?? throw new ArgumentNullException(nameof(vendorService));
            _contextAccessor = contextAccessor;
            _facilityService = facilityService;
        }
        [HttpPost]
        [Route("/Vendor/SignUp")]
        public async Task<IActionResult> SignUp([FromForm] Vendor v, string password)
        {

             var vendor = await _vendorService.CreateVendor(v, password);



            if (vendor != null)
            {
                return RedirectToAction("SignIn");
            }



            return View();

        }
   
        [Route("/Vendor/SignUp")]
        public async Task<IActionResult> SignUp()
        { 
            return View();
        }
        [Route("/Vendor/SignIn")]
        public async Task<IActionResult> SignIn()
        {
            return View();
        }

        [Route("/Vendor/SignIn")]
        [HttpPost]
       public async Task<IActionResult> SignIn([FromForm]string Email, string password)
        {
            var vendor = await _vendorService.Login(Email, password);
            if(vendor!= null)
            {
                _contextAccessor.HttpContext.Session.SetInt32("VendorId",vendor._Id);
                    
                return RedirectToAction("Main");
            }
            else
            {
                return View("NotFound");
            }
        }
            [Route("/Vendor/Main")]
            public async Task<IActionResult> Main()
            {
                    var id = _contextAccessor.HttpContext.Session.GetInt32("VendorId");
            

            if (id != null)
            { 
                var facilities = await _facilityService.FilterByOwner((int)id);
                return View(facilities);
            }
            else return null;
            }

    }
}