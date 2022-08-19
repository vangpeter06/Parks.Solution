using Mircosoft.EntityFrameworkCore;

namespace Parks.Models
{
  public class ParkContext : DbContext
  {
    public ParkContext(DbContextOptions<ParkContext> options)
      : base(options)
      {
      }

      public DbSet<Animal> Animals { get; set; }
  }
}