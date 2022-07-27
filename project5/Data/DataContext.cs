

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using project.Model;
using Project.Model;

namespace Project.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<IdentityDbContext> options) : base(options)
        {

        }
       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer()
                .UseSqlServer("Server=192.168.1.8,1433;Database=project;User Id=newproject;Password=1234;");
        }*/

        public DbSet<User> Users2 => Set<User>();
        public DbSet<ResetPasswordRequest> ResetPasswordRequest => Set<ResetPasswordRequest>();


    }

}
