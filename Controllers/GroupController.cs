using Microsoft.AspNetCore.Mvc;
using SkillShareMentor.Backend.Data;
using SkillShareMentor.Backend.DTOs;
using SkillShareMentor.Backend.Models;

namespace SkillShareMentor.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly AppDbContext _context;

        public GroupController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateGroup([FromBody] CreateGroupRequest request)
        {
            var newGroup = new StudyGroup
            {
                Name = request.Name,
                Subject = request.Subject,
                Topic = request.Topic,
                Description = request.Description,
                Privacy = request.Privacy,
                CreatedByUserId = request.CreatorUserId,
                CreatedAt = DateTime.UtcNow
            };

            _context.StudyGroups.Add(newGroup);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Grupo creado exitosamente", groupId = newGroup.Id });
        }
    }
}