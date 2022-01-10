using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmoothBoardStylers.Models;

namespace SmoothBoardStylers.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Klant> Klanten { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}