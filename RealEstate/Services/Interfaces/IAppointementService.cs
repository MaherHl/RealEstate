using RealEstate.Models;

namespace RealEstate.Services.Interfaces
{
    public interface IAppointementService
    {

        public Task<bool> IsAvailable(int id, DateTime date);

        public Task<Appointement> BookATour(Appointement appointement);

        public Task<List<Appointement>> getAll(int id);
    }
}
