using RealEstate2.Models;

namespace RealEstate2.Servives.Interfaces
{
    public interface IVendorService
    {
        Task<Vendor> GetVendorByID(int Id );
        List<Vendor> GetAll();
        Task<bool> VendorExists(int Id);
         Task<Vendor> CreateVendor(Vendor v ,string password);
        Task<Vendor> UpdateVendor(Vendor v);
        Task<Vendor> DeleteVendor(int Id);
        Task<bool> Login(string username, string password);
        

    }
}
