using FloraCapstone2nd.Model;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Microsoft.Extensions.Configuration;


namespace FloraCapstone2nd.Data
{
    
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("server=localhost;port=3306;database=floradb;user=root;password=root1234", ServerVersion.AutoDetect("server=localhost;port=3306;database=floradb;user=root;password=root1234"));
        }
        //put other database tables after this

        public DbSet<User> Users { get; set; }
    }
    
    
}
