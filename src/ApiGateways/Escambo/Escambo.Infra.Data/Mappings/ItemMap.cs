using Escambo.Domain.Entities;
using Escambo.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escambo.Infra.Data.Mappings
{
    public class ItemMap : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(c => c.Id).HasColumnName("id");
            builder.Property(n => n.Description).HasColumnName("description").HasMaxLength(150).IsRequired();
            builder.Property(p => p.UserId).HasColumnName("user_id").IsRequired();
            builder.Property(p => p.Name).HasColumnName("name").HasMaxLength(100).IsRequired();
            builder.Property(p => p.Type).HasColumnName("type").HasDefaultValue(ItemType.Have).IsRequired();
            builder.Property(p => p.Hired).HasColumnName("hired").IsRequired();
        }
    }
}
