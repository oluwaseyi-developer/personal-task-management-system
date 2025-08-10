using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagementSystem.Domain.Entities;

namespace TaskManagementSystem.Persistence.Configurations
{
    public class AttachmentConfiguration : IEntityTypeConfiguration<Attachment>
    {
        public void Configure(EntityTypeBuilder<Attachment> builder)
        {
            builder.HasKey(att => att.Id);

            builder.Property(att => att.FileName)
                   .IsRequired()
                   .HasMaxLength(255);

            builder.Property(att => att.FilePath)
                   .IsRequired()
                   .HasMaxLength(1000);

            builder.Property(att => att.ContentType)
                   .HasMaxLength(100);

        }
    }
}
