using Microsoft.EntityFrameworkCore;
using RailwayTicketSystem.Models;

namespace RailwayTicketSystem.Models
{
    public class RailwayDbContext : DbContext
    {
        public RailwayDbContext(DbContextOptions<RailwayDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        public DbSet<City> Cities { get; set; }
    }
}   
