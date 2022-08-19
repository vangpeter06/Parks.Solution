using Microsoft.EntityFrameworkCore;

namespace Parks.Models
{
    public class ParksContext : DbContext
    {
        public ParksContext(DbContextOptions<ParksContext> options) :
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Park>()
                .HasData(new Park {
                    ParkId = 1,
                    Name = "Crater Lake",
                    Location = "Oregon",
                    Type = "National"
                },
                new Park {
                    ParkId = 2,
                    Name = "Yosemite National Park",
                    Location = "California",
                    Type = "National"
                },
                new Park {
                    ParkId = 3,
                    Name = "Bryce Canyon Nation Park",
                    Location = "Utah",
                    Type = "National"
                },
                new Park {
                    ParkId = 4,
                    Name = "Zion National Park",
                    Location = "Utah",
                    Type = "National"
                },
                new Park {
                    ParkId = 5,
                    Name = "Blue Lake",
                    Location = "Oregon",
                    Type = "State"
                },
                new Park {
                    ParkId = 6,
                    Name = "Merced's Applegate Park Zoo",
                    Location = "California",
                    Type = "State"
                },
                new Park {
                    ParkId = 7,
                    Name = "Fairview Community Park",
                    Location = "Oregon",
                    Type = "City"
                });
        }

        public DbSet<Park> Parks { get; set; }
    }
}
