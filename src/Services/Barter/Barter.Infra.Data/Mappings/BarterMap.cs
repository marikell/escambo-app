using Microsoft.EntityFrameworkCore;

namespace Barter.Infra.Data.Mappings
{
    public class BarterMap : IEntityTypeConfiguration<Domain.Entities.Barter>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Domain.Entities.Barter> builder)
        {
            
        }
    }
}
