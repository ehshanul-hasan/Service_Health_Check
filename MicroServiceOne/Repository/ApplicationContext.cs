using Microsoft.EntityFrameworkCore;

namespace MicroServiceOne.Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Application_Src");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Add Dummy Data Here If Needed
            //base.OnModelCreating(modelBuilder);
        }


    }
}
