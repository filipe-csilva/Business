using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Business.Data.Map
{
    public class BrandMap : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);

            builder.HasMany(x => x.Suppliers)
                   .WithMany(x => x.Brands)
                   .UsingEntity(x => x.ToTable("SupplierByBrand"));

            builder.HasMany(x => x.Products)
                   .WithOne(x => x.Brand);
        }
    }
}
