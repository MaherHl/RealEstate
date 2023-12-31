using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace RealEstate2.Models
{
    public class Vendor
    {
        [Key]
        public int _Id { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string lastname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required]
        public string Password { get; set; }
        public List<facility> RealEstate { get; set; } = new List<facility>();
    }
}