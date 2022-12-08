using Microsoft.EntityFrameworkCore;

namespace CarRental.Models
{
    public class CarsContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public CarsContext(DbContextOptions<CarsContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
