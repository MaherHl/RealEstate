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
            var facilty = await _DbContext.Facilities.FindAsync(id);
            return facilty.Appointements.ToList();
        }

        public async Task<bool> IsAvailable(int id, DateTime BookingDate)
        {
           var facility = await _DbContext.Facilities.FirstOrDefaultAsync(f=>f._id== id);
            if (facility==null)
            {
                throw new ArgumentNullException(nameof(facility));
            }
            if (facility.Appointements == null || !facility.Appointements.Any())
            {
                return true; 
            }
            foreach (var appointment in facility.Appointements)
             {
                        if (appointment.date == BookingDate)
                        {
                        return false; 
                        }

             }
            return true;
           

        }
    }
}
