using Microsoft.EntityFrameworkCore;

namespace Barter.Infra.Data.Mappings
{
    public class BarterMap : IEntityTypeConfiguration<Domain.Entities.Barter>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Domain.Entities.Barter> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(k => k.Id).HasColumnName("id");
            builder.Property(p => p.HasFinished).HasColumnName("finished").IsRequired();
            builder.Property(p => p.ItemOfferedId).HasColumnName("item_offered_id").IsRequired();
            builder.Property(p => p.ItemReceivedId).HasColumnName("item_received_id").IsRequired();
            builder.Property(p => p.Date).HasColumnName("date").IsRequired();
        }
    }
}
