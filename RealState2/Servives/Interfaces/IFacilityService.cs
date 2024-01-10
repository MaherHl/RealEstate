using RealEstate2.Models;

namespace RealEstate2.Servives.Interfaces
{
    public interface IFacilityService
    {
        public Task<facility> GetFaciltyById(int id);
   
         public Task<facility> Deletefacility(int id, Vendor v);
        public Task<facility> Updatefacilty(int id, facility f , Vendor v);
        public Task<List<facility>> GetAll();
        public Task<facility> AddFacilty(facility f);

        public Task<facility> FaciltyGetByName(string Name);
        public Task<List<facility>> Filter(rentingType type, string city, int NbRooms, PropertyType type2);

    }
}
