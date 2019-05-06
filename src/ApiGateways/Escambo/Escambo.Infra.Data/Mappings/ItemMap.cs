using Escambo.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escambo.Infra.Data.Mappings
{
    public class ItemMap : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.Property(c => c.Id).HasColumnName("id");
            builder.Property(n => n.Description).HasColumnName("description");
            builder.Property(p => p.UserId).HasColumnName("user_id");
            //builder.HasOne(p => p.User).WithMany(o => o.Items).HasForeignKey(x => x.UserId);
        }
    }
}
