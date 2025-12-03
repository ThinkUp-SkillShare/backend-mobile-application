namespace SkillShareMentor.Backend.DTOs
{
    public class UpdateUserRequest
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Nickname { get; set; }
        public string? Institution { get; set; }
        public string? Country { get; set; }
        public string? Gender { get; set; }
    }
}