using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Models;
using RealEstate.Services.Interfaces;

namespace RealEstate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointementsController : ControllerBase
    {
        private readonly IAppointementService _appointementService;
        public AppointementsController(IAppointementService appointementService)
        {
            _appointementService = appointementService;
        }



        [HttpGet("/{FacilityId}/getAppointements")]
        [Authorize]
        public async Task<IActionResult> Get(int FacilityId)

        {
            try
            {
                var app = await _appointementService.getAll(FacilityId);
                return Ok(app);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost("/{FaciltyId}/AddAppointement")]
        [Authorize]
        public async Task<IActionResult> BookAToor(int FaciltyId, [FromForm]Appointement A)
        {
            var isAvailable = await _appointementService.IsAvailable(A.FacilityId, A.date);
            if (isAvailable==false) {
                return Ok("The Day is full");
            }
            try
            {
            var app = await _appointementService.BookATour(A);
                
                    return Ok(app);

               

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
              

           
            

        }




    }
}
