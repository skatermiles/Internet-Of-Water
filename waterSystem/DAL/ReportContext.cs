using waterSystem.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace ContosoUniversity.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolContext")
        {
        }

        public DbSet<User> Users{ get; set; }
        public DbSet<ReportType> ReportTypes { get; set; }
        public DbSet<Report> Reports { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
