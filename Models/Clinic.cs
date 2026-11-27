using System.ComponentModel.DataAnnotations;

namespace VeterinerKlinikSistemi.Models
{
    public class Clinic
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Klinik adı zorunludur.")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Adres bilgisi zorunludur.")]
        [StringLength(250)]
        public string Address { get; set; } = string.Empty;

        [Phone]
        [StringLength(20)]
        public string? PhoneNumber { get; set; }
        public string WorkingHours { get; set; } = "09:00 - 18:00";
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}