using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstate.Models
{
    public class Appointement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id {  get; set; }
        public string ClientName {  get; set; }
        public int FacilityId { get; set; }
        public DateTime date { get; set; }
        public int? AgentId { get; set; }
    }
}
