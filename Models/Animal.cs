using System.ComponentModel.DataAnnotations;

namespace CretaceousPark.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public string Species { get; set; }
        [Required]
        [Range(0, 450, ErrorMessage = "Age cannot be below 0 and must be 450 or below.")]
        public int Age { get; set; }
        public string Gender { get; set; }
    }
}