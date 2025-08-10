using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagementSystem.Domain.Entities;

namespace TaskManagementSystem.Persistence.Configurations
{
    public class UserProfileConfiguration : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.HasKey(up => up.Id);

            builder.Property(up => up.FirstName)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(up => up.LastName)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(up => up.Email)
                   .IsRequired()
                   .HasMaxLength(200);
        }
    }
}
