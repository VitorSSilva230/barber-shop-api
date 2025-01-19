using BarberShopV2.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberShopV2.Data.Mappings
{
    public class ProfessionalMapping : IEntityTypeConfiguration<Professional>
    {
        public void Configure(EntityTypeBuilder<Professional> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.HasOne(x => x.Address)
                .WithOne(a => a.Professional);

            builder.ToTable("Professionals");
        }
    }
}
