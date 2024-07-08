using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Models.Dtos.BaseDtos;

namespace UserManagementSystem.Models.IdentityConfig
{
    internal class UserRefreshTokenConfiguration : IEntityTypeConfiguration<UserRefreshTokenDto>
    {
        public void Configure(EntityTypeBuilder<UserRefreshTokenDto> builder)
        {
            builder.HasKey(x => x.UserId);
            builder.Property(x => x.Code).IsRequired().HasMaxLength(200);
        }
    }
}
