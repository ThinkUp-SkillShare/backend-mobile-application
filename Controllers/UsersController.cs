using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkillShareMentor.Backend.Data;
using SkillShareMentor.Backend.DTOs;

namespace SkillShareMentor.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] UpdateUserRequest request)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound(new { message = "Usuario no encontrado" });
            }

            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.Nickname = request.Nickname;
            user.Institution = request.Institution;
            user.Country = request.Country;
            user.Gender = request.Gender;

            await _context.SaveChangesAsync();

            return Ok(new { message = "Perfil actualizado correctamente", user });
        }
    }
}