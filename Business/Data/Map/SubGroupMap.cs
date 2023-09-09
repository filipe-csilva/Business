using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Business.Data.Map
{
    public class SubGroupMap : IEntityTypeConfiguration<SubGroup>
    {
        public void Configure(EntityTypeBuilder<SubGroup> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(30);
            //builder.HasOne(x => x.Group).WithMany(g => g.subGrups).HasForeignKey(f => f.GroupId);
        }
    }
}
