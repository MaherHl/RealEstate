using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using RealEstate2.Models;
using RealEstate2.Servives.Interfaces;
using RealState2.Data;

namespace RealEstate2.Servives
{
    public class FacilityService : IFacilityService
    {
        private readonly RealEstateDbContext _dbContext;
        public FacilityService(RealEstateDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<facility> AddFacilty(facility f)
        {
            if( f == null) { throw new ArgumentNullException(nameof(f)); 
            }
           
           var newFacilty=  await _dbContext.Facilities.AddAsync(f);
            await _dbContext.SaveChangesAsync();
            return newFacilty.Entity ;
        }

        public async Task<facility> Deletefacility(int id , Vendor v)
        {
            var Facilty = await _dbContext.Facilities.FindAsync(id);
                if (Facilty== null )
            {
                Console.WriteLine("Facility Not Found");
                return null;

            };
            if (v._Id == Facilty.Owner._Id)
            {
                var deletedFacility = _dbContext.Facilities.Remove(Facilty);
               await  _dbContext.SaveChangesAsync();

                return deletedFacility.Entity;

            }
            else return null;



         }       

        public async Task<facility> FaciltyGetByName(string Name)
        {
            if (Name != null) {
                var Facilty = await _dbContext.Facilities
                    .FirstOrDefaultAsync(f=>f.FacilityName==Name);
                if(Facilty== null)
                {
                    Console.WriteLine("Not Found");
                    return null;

                }
                else
                {
                    return Facilty;
                }
            }else
            {
                return null;
            }
        }

        public async Task<List<facility>> FilterByCity(string city)
        {
            if(city != null)
            {
                var FacilitiesInCity = await  _dbContext.Facilities
                    .Where(f => f.City==city)
                    .ToListAsync();
                return FacilitiesInCity;
            }
            else
            {
                Console.WriteLine("Invalid city parameter");
                return null;
            }
        }

        public async Task<List<facility>> Filter(rentingType type, string city, int NbRooms , PropertyType type2)
        {
            try
            {
                var facilitiesByRentingType = await _dbContext.Facilities
                    .Where(f => f.rentingType == type   || f.rooms == NbRooms ||  f.PropertyType== type2 || f.City.Contains(city) )
                    .ToListAsync();

                return facilitiesByRentingType;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error filtering facilities by renting type: {ex.Message}");
                return null;
            }
        }




        public async Task<List<facility>> GetAll()
        {
            try
            {

            var facilties =   await _dbContext.Facilities.ToListAsync();
            return facilties;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }

        public async Task<facility> GetFaciltyById(int id)
        {
            var Facility = await _dbContext.Facilities.FindAsync(id);
            return Facility;
        }

        public async Task<facility> Updatefacilty(int id, facility updatedFacility, Vendor v)
        {

            var oldFacility = await _dbContext.Facilities.FindAsync(id);
            if (oldFacility != null)
            {
                if(v._Id == oldFacility.Owner._Id)
                {


                oldFacility.FacilityName = updatedFacility.FacilityName;
                oldFacility.PropertyType = updatedFacility.PropertyType;
                oldFacility.Price = updatedFacility.Price;
                oldFacility.availability = updatedFacility.availability;
                oldFacility.rate = updatedFacility.rate;
                oldFacility.rentingType = updatedFacility.rentingType;
                oldFacility.description = updatedFacility.description;
                oldFacility.location = updatedFacility.location;
                oldFacility.City = updatedFacility.City;
                oldFacility.rooms = updatedFacility.rooms;
                oldFacility.baths = updatedFacility.baths;
                oldFacility.amenities = updatedFacility.amenities;
                oldFacility.isPetFriendly = updatedFacility.isPetFriendly;
                   await _dbContext.SaveChangesAsync();

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
