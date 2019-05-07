using Microsoft.EntityFrameworkCore;

namespace User.Infra.Data.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User.Domain.Entities.User>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User.Domain.Entities.User> builder)
        {
            builder.Property(o => o.Name).HasMaxLength(140).IsRequired();
            builder.Property(o => o.Email).HasMaxLength(100).IsRequired();
        }
    }
}
