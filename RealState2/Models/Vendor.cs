using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace RealEstate2.Models
{
    public class Vendor : IdentityUser
    {
        [Key]
        public int _Id { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string LastName { get; set; }
    
        [Required]
        public string Phone { get; set; }
        [Required]
       
        public List<facility> Facilities { get; set; } = new List<facility>();
    }
}