using System.ComponentModel.DataAnnotations;

namespace SkillShareMentor.Backend.DTOs
{
    public class CreateGroupRequest
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Topic { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Privacy { get; set; } = "Public";

        [Required]
        public int CreatorUserId { get; set; }
    }
}