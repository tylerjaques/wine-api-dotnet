using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Wine.Api.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Events { get; set; } = null!;
    }
}