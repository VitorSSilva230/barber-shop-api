using BarberShopV2.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberShopV2.Data.Mappings
{
    public class CustomerMapping : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.HasOne(x => x.Address)
                .WithOne(a => a.Customer);

            builder.HasMany(x => x.Appointments)
                .WithOne(a => a.Costumer);


            builder.ToTable("Customers");
        }
    }
}
