using DigitalLibrary.DAL.Entityes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigitalLibrary.DAL.Configurations
{
    internal class BookConfiguration : IEntityTypeConfiguration<BookEntity>
    {
        public void Configure(EntityTypeBuilder<BookEntity> builder)
        {
            builder.ToTable("Books");
            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName(nameof(BookEntity.Id).ToLower());
            builder.Property(x => x.Title).HasMaxLength(255).HasColumnName(nameof(BookEntity.Title).ToLower()).IsRequired();
            builder.Property(x => x.YearRelease).HasColumnName("year_release").IsRequired();
        }
    }
}
