using Microsoft.AspNetCore.Mvc;
using RealEstate2.Models;
using RealEstate2.Servives.Interfaces;

namespace RealEstate2.Controllers
{
    public class FacilityController : Controller

    { 
        public readonly IHttpContextAccessor _contextAccessor;
        private readonly IFacilityService _facilityService;
         public FacilityController(IHttpContextAccessor contextAccessor,IFacilityService facilityService)
        {
            _contextAccessor = contextAccessor;
            _facilityService = facilityService;
        }
      
        public IActionResult Index()
        {
            return View();
        }

        [Route("Facility/Add")]
        public IActionResult Add()
        {
            
            
            return View();
        }


        [HttpPost]
        [Route("Facility/Add")]
        public async Task<IActionResult> Add([FromForm]facility f)
        {
           var facilty = await _facilityService.AddFacilty(f);
            if (facilty != null)
            {
                return RedirectToAction("Main","Vendor");

            }
            else return null;


        }

		[Route("Facility/All")]
		public IActionResult All()
		{


			return View();
		}

        [Route("Facility/Edit")]
        public async Task<IActionResult> Edit(int id)
        {
           var facility = await _facilityService.GetFaciltyById(id);
            if (facility != null)
            {
            _contextAccessor.HttpContext.Session.SetInt32("FacilityId", facility._id);

            return View();
            }
            return null;

        }


        [Route("Facility/Edit")]
        [HttpPost]
        public async Task<IActionResult> Edit([FromForm]facility f)
        {
            var VendorId = _contextAccessor.HttpContext.Session.GetInt32("VendorId");
            var FacilityId = _contextAccessor.HttpContext.Session.GetInt32("FacilityId");
            var UpdatedFacility = await _facilityService.Updatefacilty((int)FacilityId,f,(int)VendorId);

            if (UpdatedFacility!= null)
            {

                return RedirectToAction("Main", "Vendor");

            }
            else return View();

        }
       /* [HttpPost,ActionName("Delete")]
        [Route("Facility/Delete")]
        public async Task<IActionResult> Delete()
        {
            var VendorId = _contextAccessor.HttpContext.Session.GetInt32("VendorId");
            var FacilityId = _contextAccessor.HttpContext.Session.GetInt32("FacilityId");
            var DeletedFacility = await _facilityService.Deletefacility((int)FacilityId,  (int)VendorId);

            if (DeletedFacility != null)
            {
                // Facility successfully deleted
                return View();
            }
            else
            {
                // Facility not found or unauthorized
                return NotFound(new { success = false, error = "Facility not found or unauthorized" });
            }
        }*/
    }
}
