using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace HotelListing.Api.Data
{
    public class HotelListingDbContext: DbContext
    {
        public HotelListingDbContext(DbContextOptions<HotelListingDbContext> Options) :base(Options) 
        {


        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels{ get; set; }


    }
}
