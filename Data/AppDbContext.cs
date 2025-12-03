using Microsoft.EntityFrameworkCore;
using SkillShareMentor.Backend.Models;

namespace SkillShareMentor.Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<StudyGroup> StudyGroups { get; set; }
    }
}