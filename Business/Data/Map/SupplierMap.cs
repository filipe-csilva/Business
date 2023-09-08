using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Business.Data.Map
{
    public class SupplierMap : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CNPJ).IsRequired().HasAnnotation("MinLength", 14).HasMaxLength(14);
            builder.Property(x => x.IE).IsRequired().HasAnnotation("MinLength", 10).HasMaxLength(10);

            builder.HasMany(x => x.Products)
                   .WithOne(x => x.Supplier);
        }
    }
}
