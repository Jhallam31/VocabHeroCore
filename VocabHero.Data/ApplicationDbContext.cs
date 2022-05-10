using Microsoft.EntityFrameworkCore;
using VocabHero.Data.Entities;

namespace VocabHero.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<UserEntity> Users { get; set; }
    }
}