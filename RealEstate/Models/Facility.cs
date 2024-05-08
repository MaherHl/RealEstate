using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace RealEstate.Models
{
    public enum PropertyType
    {
        appartement, Desk, Studio
    }
    public enum rentingType
    {
        daily, Monthly
    }
    public class Facility
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int _id { get; set; }
        public string FacilityName { get; set; }
        public PropertyType? PropertyType { get; set; }
        public double Price { get; set; }
        public bool availability { get; set; }
        public double? rate { get; set; }
        public rentingType? rentingType { get; set; }
        public string? ProfileImagePath { get; set; }
        [NotMapped]
        public IFormFile? PictureFile { get; set; }
        public int  AgentId{ get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string City { get; set; }
        public int rooms { get; set; }
        public bool isPetFriendly { get; set; }
        
    }
}
