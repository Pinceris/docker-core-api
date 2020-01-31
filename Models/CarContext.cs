using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options)
            : base(options)
        {
        }

        public DbSet<CarModel> Cars { get; set; }
    }
}