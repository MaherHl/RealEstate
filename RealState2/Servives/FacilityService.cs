using Microsoft.EntityFrameworkCore;
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

        public Task<facility> Deletefacility(int id)
        {
            throw new NotImplementedException();
        }

        public Task<facility> FaciltyGetByName(string Name)
        {
            throw new NotImplementedException();
        }

        public Task<facility> FilterByCity(string city)
        {
            throw new NotImplementedException();
        }

        public Task<facility> FilterByRentingType(rentingType type)
        {
            throw new NotImplementedException();
        }

        public Task<facility> FilterByRooms(int NbRooms)
        {
            throw new NotImplementedException();
        }

        public Task<facility> FilterByType(PropertyType type)
        {
            throw new NotImplementedException();
        }

        public Task<facility> GetAll(Vendor v)
        {
            throw new NotImplementedException();
        }

        public Task<facility> GetFaciltyById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<facility> Updatefacilty(int id)
        {
            throw new NotImplementedException();
        }
    }
}
