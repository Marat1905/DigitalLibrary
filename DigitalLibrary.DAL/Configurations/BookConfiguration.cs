using DigitalLibrary.DAL.Entityes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigitalLibrary.DAL.Configurations
{
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");
            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName(nameof(Book.Id).ToLower());
            builder.Property(x => x.Title).HasMaxLength(255).HasColumnName(nameof(Book.Title).ToLower()).IsRequired();
            builder.Property(x => x.YearRelease).HasColumnName("year_release").IsRequired();
        }
    }
}
