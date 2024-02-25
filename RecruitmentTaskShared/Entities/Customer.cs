using System.ComponentModel.DataAnnotations;

namespace RecruitmentTaskShared.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Name is required")]
        [MinLength(3, ErrorMessage = "Name must be at least 3 characters")]
        [MaxLength(16, ErrorMessage = "Name must not exceed 16 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [MinLength(3, ErrorMessage = "Address must be at least 3 characters")]
        [MaxLength(24, ErrorMessage = "Address must not exceed 24 characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "NIP is required")]
        [Range(1000000000, 9999999999, ErrorMessage = "NIP must be a 10-digit number")]
        public int NIP { get; set; }
    }
}