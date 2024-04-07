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
              var app = await  _appointementService.getAll(FacilityId);
                return Ok(app);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost("/{FaciltyId}/AddAppointement")]
        [Authorize]
        public async Task<IActionResult> BookAToor(int FaciltyId, Appointement A, DateTime d)
        {
            var isAvailable = await _appointementService.IsAvailable(FaciltyId, d);
            if (isAvailable == true)
            {
                var app = await _appointementService.BookATour(A);
                if (app != null)
                {
                    return Ok(app);

                }
                else return BadRequest("ERROR WHILE TRYING TO BOOK A DAY ");

            }
            else return BadRequest("day is booked");

        }




    }
}
