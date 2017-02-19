using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TestTrip.Models;

namespace TripTest.Dal
{
    public class TripContext : DbContext
    {
        public DbSet<Trip> Trips { get; set; }

        public TripContext()
            : base("TripContext")
        {
        }        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
