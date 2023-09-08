using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Business.Models;

namespace Business.Data.Map
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(30);
            builder.Property(x => x.GTIN).HasMaxLength(20);
            builder.Property(x => x.PricePurchase).HasColumnType("decimal(18, 2)").HasDefaultValue(0.00).HasAnnotation("MinValue", 0.01);
            builder.Property(x => x.PriceCoast).HasColumnType("decimal(18, 2)").HasDefaultValue(0.00).HasAnnotation("MinValue", 0.01);
            builder.Property(x => x.PriceSale).HasColumnType("decimal(18, 2)").HasDefaultValue(0.00).HasAnnotation("MinValue", 0.01);
            builder.Property(x => x.Description).HasMaxLength(1024);

            builder.HasMany(x => x.Clients)
                   .WithMany(x => x.Products)
                   .UsingEntity(x => x.ToTable("ClientByProduct"));
        }
    }
}