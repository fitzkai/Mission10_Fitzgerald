using System.ComponentModel.DataAnnotations;

namespace Mission10_Fitzgerald.Data
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        [Required]
        public string TeamName { get; set; }
        
        public int? CaptainID { get; set; }
    }
}
