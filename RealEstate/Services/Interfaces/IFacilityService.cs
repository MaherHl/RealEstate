using RealEstate.Models;

namespace RealEstate.Services.Interfaces
{
    public interface IFacilityService
    {


        public  Task<Facility> DeleteFacility(int id, int userID );
        public  Task<Facility> AddFacility(Facility facility, int id);
        public  Task<Facility> GetFaciltyById(int id);
        public  Task<List<Facility>> GetAll();
        public Task<List<Facility>> GetAllByOwner(int userID);
        public  Task<List<Facility>> FaciltyGetByName(string Name);
        public  Task<Facility> Updatefacilty(int id, Facility updatedFacility, int VendorId);
        public  Task<List<Facility>> GetAllByCity(string city);
    }
}
