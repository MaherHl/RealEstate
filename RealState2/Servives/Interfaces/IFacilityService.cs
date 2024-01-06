using RealEstate2.Models;

namespace RealEstate2.Servives.Interfaces
{
    public interface IFacilityService
    {
        public Task<facility> GetFaciltyById(int id);
        public Task<facility> FilterByCity(string city);
         public Task<facility> Deletefacility(int id);
        public Task<facility> Updatefacilty(int id);
        public Task<facility> GetAll(Vendor v);
        public Task<facility> AddFacilty(facility f);
        public Task<facility> FilterByRooms(int NbRooms);
        public Task<facility> FaciltyGetByName(string Name);
        public Task<facility> FilterByType(PropertyType type);
        public Task<facility> FilterByRentingType(rentingType type);

    }
}
