using System.ComponentModel.DataAnnotations;

namespace SkillShareMentor.Backend.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string? Nickname { get; set; }
        public string? UniversityDocument { get; set; }
        public string? Institution { get; set; }
        public string? Country { get; set; }
        public string? Gender { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}