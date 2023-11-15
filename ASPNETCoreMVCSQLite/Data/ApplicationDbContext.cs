using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ASPNETCoreMVCSQLite.Models;

namespace ASPNETCoreMVCSQLite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ASPNETCoreMVCSQLite.Models.Product> Product { get; set; } = default!;
    }
}