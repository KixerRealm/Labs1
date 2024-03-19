using Application.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Application.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Application.Web.Models.Ticket> Ticket { get; set; } = default!;
        public DbSet<Application.Web.Models.TheatreShow> TheatreShow { get; set; } = default!;
    }
}
