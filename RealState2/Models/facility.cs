using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace RealEstate2.Models
{
    public enum PropertyType
    {
        appartement, Desk , Studio 
    }
    public enum rentingType
    {
        daily, Monthly
    }
    public class facility
    {
        [Key]
        public int _id { get; set; }
        public string FacilityName { get; set; }
        public PropertyType? PropertyType { get; set; }
        public double Price { get; set; }
        public bool availability { get; set; }
        public double rate { get; set; }
        public rentingType? rentingType { get; set; }
        public Vendor Owner {  get; set; }
        public int VendorId { get; set; }
        public string description { get; set; }
        public string location {  get; set; }
        public string City{ get; set; }
        public int rooms { get; set; }
        public int baths { get; set; }

       public List<string> amenities {  get; set; }
        public bool isPetFriendly { get; set; }   
    }
}
