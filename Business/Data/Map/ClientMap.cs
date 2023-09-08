using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Business.Data.Map
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.CPF).IsRequired().HasAnnotation("MinLength", 11).HasMaxLength(11);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Number).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Borhood).IsRequired().HasMaxLength(30);
            builder.Property(x => x.City).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Region).IsRequired().HasMaxLength(30);
            builder.Property(x => x.PostalCode).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Fone).IsRequired().HasMaxLength(14);
        }
    }
}
