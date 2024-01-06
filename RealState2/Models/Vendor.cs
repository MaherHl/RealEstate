using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstate2.Models
{
    public class Vendor 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int _Id { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string LastName { get; set; }
        public string ProfilePictute { get; set; }
        public string Email { get; set; }
    
        [Required]
        public string Phone { get; set; }
        public string UserId { get; set; }
        [NotMapped]
         public string Password { get; set; }

        public List<facility> Facilities { get; set; }
    }
}