using Microsoft.EntityFrameworkCore;

namespace AdvLab_WebApis.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    ID = 1,
                    EmpID = 1,
                    UName = "Admin",
                    UPassword = "admin@786",
                    Status = "Yes",
                    CNL = "MAIN-LAB",
                    ClientV = "Main",
                    CompMac = "Null",
                    Depart = "All",
                    SubDepart = "All",
                    Placement = "Path",
                    Designation = "IT",
                    Idloc = "Main",
                    RoleID = 17,
                    Location = "Main",
                    LoginStatus = "No",
                    LoginStatusComp = "Null",
                    LoginStatusIP = "Null",
                    NSend = "No",
                    PayGenerate = "No",
                    Place = "Null",
                    PlaceCategory = "Null",
                    Token = "Null"
                });
        }
        public DbSet<User> Users { get; set; }
        public virtual DbSet<LoginLog> LoginLogs { get; set; }
        public virtual DbSet<AddLocation> AddLocations { get; set; }
        public virtual DbSet<AddConnLab> AddConnLabs { get; set; }
        public virtual DbSet<AccessRight> AccessRights { get; set; }
    }

}
