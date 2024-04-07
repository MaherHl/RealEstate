using System.ComponentModel.DataAnnotations;
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
        public int _id { get; set; }
        public string FacilityName { get; set; }
        public PropertyType? PropertyType { get; set; }
        public double Price { get; set; }
        public bool availability { get; set; }
        public double? rate { get; set; }
        public rentingType? rentingType { get; set; }
        public Agent agent  { get; set; }
        public int  AgentId{ get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string City { get; set; }
        public int rooms { get; set; }
        public bool isPetFriendly { get; set; }
        public List<Appointement> Appointements;
    }
}
