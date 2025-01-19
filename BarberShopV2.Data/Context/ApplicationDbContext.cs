using BarberShopV2.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BarberShopV2.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> customers { get; set; }
        public DbSet<Professional> professionals { get; set; }
        public DbSet<Appointment> appointments { get; set; }
        public DbSet<Address> addresses { get; set; }
    }
}
