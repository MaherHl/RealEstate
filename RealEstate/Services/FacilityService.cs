
using RealEstate.Services.Interfaces;
using RealEstate.Models;
using RealEstate.Data;
using Microsoft.EntityFrameworkCore;



namespace RealEstate.Services
{
    public class FacilityService : IFacilityService
    {


        private readonly RealEstateDbContext _DbContext;

        public  FacilityService(RealEstateDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        public async Task<Facility> AddFacility(Facility facility)
        {
            if (facility == null) { throw new ArgumentNullException(nameof(facility)); }
            var newFacility = await _DbContext.Facilities.AddAsync(facility);
            await _DbContext.SaveChangesAsync();
            return newFacility.Entity;

        }

        public async Task<Facility> DeleteFacility(int id , int UserId)

        {
            
            var facility = await _DbContext.Facilities.FindAsync(id);
            if(facility.AgentId == UserId) {
            
            if (facility != null)
            {
                var deletedFacility = _DbContext.Facilities.Remove(facility);
                await _DbContext.SaveChangesAsync();

                return deletedFacility.Entity;

            }
            }
            return null;

         }
         public async Task<Facility> GetFaciltyById(int id)
          {
                 var facility = await _DbContext.Facilities.FirstOrDefaultAsync(f=> f._id == id);
                 return facility;
            }


        public async Task<List<Facility>> GetAll()
        {
            var facilities = await _DbContext.Facilities.ToListAsync();
            
            return facilities;
        } 


        public async Task<List<Facility>> GetAllByOwner(int userID)
        {
            var facilities = await _DbContext.Facilities.Where(f=> f.AgentId == userID).ToListAsync();
            return facilities;
        }

        public async Task<List<Facility>> FaciltyGetByName(string Name)
        {
            if (Name != null)
            {
                var Facilty = await _DbContext.Facilities
                    .Where(f => f.FacilityName.Contains(Name)).ToListAsync(); 
                if (Facilty == null)
                {
                    Console.WriteLine("Not Found");
                    return null;

                }
                else
                {
                    return Facilty;
                }
            }
            else
            {
                return null;
            }

        }
        public async Task<Facility> Updatefacilty(int id, Facility updatedFacility, int VendorId)
        {

            var oldFacility = await _DbContext.Facilities.FindAsync(id);
            if (oldFacility != null)
            {
                if (VendorId == oldFacility.AgentId)
                {


                    oldFacility.FacilityName = updatedFacility.FacilityName;
                    oldFacility.PropertyType = updatedFacility.PropertyType;
                    oldFacility.Price = updatedFacility.Price;
                    oldFacility.availability = updatedFacility.availability;
                    oldFacility.rentingType = updatedFacility.rentingType;
                    oldFacility.description = updatedFacility.description;
                    oldFacility.location = updatedFacility.location;
                    oldFacility.City = updatedFacility.City;
                    oldFacility.rooms = updatedFacility.rooms;
                    oldFacility.isPetFriendly = updatedFacility.isPetFriendly;
                    await _DbContext.SaveChangesAsync();

                    return oldFacility;
                }
                else
                {
                    Console.WriteLine("Unauthorized update. Vendor does not match the owner.");
                    return null;
                }

            }

            else
            {
                Console.WriteLine("Facility not found");
                return null;
            }


        }






    }
}
