using System.ComponentModel.DataAnnotations;

namespace Parks.Models
{
    public class Park
    {
        public int ParkId { get; set; }

        [Required]
        [StringLength(85)]
        public string Name { get; set; }

        [Required]
        [StringLength(14)]
        public string Location { get; set; }

        [Required]
        [StringLength(8)]
        public string Type { get; set; }
    }
}
