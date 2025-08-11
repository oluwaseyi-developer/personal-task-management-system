using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagementSystem.Domain.Entities;

namespace TaskManagementSystem.Persistence.Configurations
{
    public class ActivityLogConfiguration : IEntityTypeConfiguration<ActivityLog>
    {
        public void Configure(EntityTypeBuilder<ActivityLog> builder)
        {
            builder.HasKey(al => al.Id);

            builder.Property(al => al.Action)
                   .IsRequired()
                   .HasMaxLength(200);
        }
    }
}
