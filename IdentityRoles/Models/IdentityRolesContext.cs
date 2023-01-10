using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace IdentityRoles.Models 
{
  public class IdentityRolesContext : IdentityDbContext<ApplicationUser>
  {
    // public DbSet<ClassName> ClassNames { get; set; }   CHANGE CLASS NAME!!!

    public IdentityRolesContext(DbContextOptions options) : base(options) { } 
  }
}
