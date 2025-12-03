using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillShareMentor.Backend.Models
{
    public class StudyGroup
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string Subject { get; set; } = string.Empty; 
        public string Topic { get; set; } = string.Empty; 
        public string Description { get; set; } = string.Empty;
        public string Privacy { get; set; } = "Public";     

        public int CreatedByUserId { get; set; }

        [ForeignKey("CreatedByUserId")]
        public User? Creator { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}