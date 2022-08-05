using Microsoft.EntityFrameworkCore;
using ScrumGit.Models;

namespace ScrumGit.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<producto> producto { get; set; }
        public DbSet<usuario> usuario { get; set; }
        public DbSet<rol> rol { get; set; }    
        
    }
}