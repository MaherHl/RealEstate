using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Models;
using RealEstate.Services.Interfaces;

namespace RealEstate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacilityController : ControllerBase
    {
        private readonly IFacilityService _facilityService;

        public FacilityController(IFacilityService facilityService)
        {
            _facilityService = facilityService;
        }

        [HttpPost("/AddFacility/{userId}")]

        public async Task<IActionResult> PostOffer([FromForm]Facility f , int userId)
        {
            try
            {
               
               await  _facilityService.AddFacility(f , userId);
                return Ok("Facility Added ");
            }
            catch (Exception ex) { 
              return BadRequest(ex.Message);
            }
        }

        [HttpDelete("/Delete/{id}/{userId}")]
        [Authorize]
        public async Task<IActionResult> DeleteFacility(int id, int userId)
        {

            try
            {
              var deletedFacility =  await _facilityService.DeleteFacility(id, userId);
                return Ok(deletedFacility);
               }
            catch (Exception ex)

            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("/getAllByOwner/{id}")]
        [Authorize]
        public async Task<IActionResult> getAllByOwner(int id )
        {
            try
            {
                var facilities = await _facilityService.GetAllByOwner(id);
                return Ok(facilities);
            }
            catch(Exception ex) {

                return BadRequest(ex.Message);
            }

        }

        [HttpPatch("/Update/{userId}/{FacilityID}")]
        [Authorize]

        public async Task<IActionResult> UpdateFacility(int userId,  Facility UpdatedFacility, int FacilityID)
        {
            try
            {
              var  updatedFacility = await _facilityService.Updatefacilty(FacilityID, UpdatedFacility, userId);
                return Ok(updatedFacility);

            } catch(Exception ex) {

                return BadRequest(ex.Message);
            }
        }


     
    }
}
