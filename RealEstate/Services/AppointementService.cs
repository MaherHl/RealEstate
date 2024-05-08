using Microsoft.EntityFrameworkCore;
using RealEstate.Data;
using RealEstate.Models;
using RealEstate.Services.Interfaces;

namespace RealEstate.Services
{
    public class AppointementService : IAppointementService
    {
        private readonly RealEstateDbContext _DbContext;

        public AppointementService(RealEstateDbContext DbContext)
        {
            _DbContext = DbContext;
        }
        public async Task<Appointement> BookATour(Appointement appointement)
        {
            if (appointement == null) { throw new ArgumentNullException(nameof(appointement)); }
            var newAppointement = await _DbContext.Appointements.AddAsync(appointement);
            if (newAppointement != null)
            {
                await _DbContext.SaveChangesAsync();
                return newAppointement.Entity;


            }
            else return null;
        }

        public async Task<List<Appointement>> getAll(int id)
        {
            var app = await _DbContext.Appointements.Where(x=>x.AgentId== id).ToListAsync();
            if(app==null)
            {
                return null;
            }
            return app;
           

        }
        public async Task<bool> IsAvailable(int id, DateTime date)
        {
            var app = await _DbContext.Appointements.FirstOrDefaultAsync(x=>x.FacilityId==id);
            if(app.date == date)
            {
                return false;
            }
            return true;
        }


    }
}
