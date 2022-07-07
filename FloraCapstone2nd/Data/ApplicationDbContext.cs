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
            var conString = "server=localhost;database=floradb;user=root;password=GString042900";
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql(conString, ServerVersion.AutoDetect(conString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().Property(p => p.Username).HasColumnType("nvarchar(50)");
            modelBuilder.Entity<User>().Property(p => p.Password).HasColumnType("nvarchar(50)");
            modelBuilder.Entity<User>().Property(p => p.Email).HasColumnType("nvarchar(50)");


        }
        //put other database tables after this

        public DbSet<User> Users { get; set; }
        public DbSet<AccountsAdmin> accountsAdmins { get; set; }
        public DbSet<Advertisements> advertisements { get; set; }
        public DbSet<Alarms> Alarms { get; set; }
        public DbSet<Bans> Bans { get; set; }
        public DbSet<Bookmarks> Bookmarks { get; set; }
        public DbSet<ContentsAdmin> contentsAdmins { get; set; }
        public DbSet<DiagnosticsAdmin> diagnosticsAdmins { get; set; }
        public DbSet<DiagnosticsMod> diagnosticsMods { get; set; }
        public DbSet<Experts> Experts { get; set; }
        public DbSet<ExpertsMod> expertsMods { get; set; }
        public DbSet<Forums> Forums { get; set; }
        public DbSet<ForumsMod> forumsMods { get; set; }
        public DbSet<HeadAdmin> headAdmins { get; set; }
        public DbSet<HowTos> howTos { get; set; }
        public DbSet<HowTosMod> HowTosMods { get; set; }
        public DbSet<Members> Members { get; set; }
        public DbSet<MembersMod> membersMods { get; set; }
        public DbSet<PlantDiseases> PlantDiseases { get; set; }
        public DbSet<Plants> Plants { get; set; }
        public DbSet<RegulatoryInfo> regulatoryInfos { get; set; }
        public DbSet<Replies> Replies { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Statistics> statistics { get; set; }
        public DbSet<Subscriptions> Subscriptions { get; set; }
        public DbSet<Warns> Warns { get; set; }

    }  
    
}
