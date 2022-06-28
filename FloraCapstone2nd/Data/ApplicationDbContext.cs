using FloraCapstone2nd.Model;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.Extensions.Configuration;

namespace FloraCapstone2nd.Data
{
    //[DbConfigurationType(typeof(MySql.Data.EntityFramework.MySqlEFConfiguration, MySql.Data.EntityFramework))]
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        { 

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conString = "server=localhost;database=floradb;user=root;password=root1234";
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql(conString, ServerVersion.AutoDetect(conString));
        }
        //put other database tables after this

        public DbSet<User> Users { get; set; }

    }
    
    
}
