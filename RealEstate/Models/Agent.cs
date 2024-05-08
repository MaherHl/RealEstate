using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace RealEstate.Models

{
   
    public class Agent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int _Id { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string LastName { get; set; }

        public string? ProfileImagePath { get; set; }
           [NotMapped]
        public IFormFile? PictureFile { get; set; }
        public string? Email { get; set; }
        [NotMapped]
        public string Password { get; set; }

        [Required]
        public string Phone { get; set; }
/*        public string UserId { get; set; }
        [NotMapped]
        public string Password { get; set; }*/
        
       
        
    }
}
