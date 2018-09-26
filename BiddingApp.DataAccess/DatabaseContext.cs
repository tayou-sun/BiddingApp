

using Microsoft.EntityFrameworkCore;

namespace BiddingApp.DataAccess
{
    public class DatabaseContext : DbContext
    {
        //public DatabaseContext()
        //{
        //    Database.EnsureCreated();
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C: \Users\Екатерина Шайнурова\Documents\BiddingDateBase.mdf;Integrated Security=True;Connect Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }


        public System.Data.Entity.DbSet<Bidding> Bidding { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=biddingsDb;Trusted_Connection=True;");
        //}
    }
}