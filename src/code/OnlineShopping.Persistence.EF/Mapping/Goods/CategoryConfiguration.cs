using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShopping.Domain.Model.Goods;

namespace OnlineShopping.Persistence.EF.Mapping.Goods
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(category => category.Title).IsRequired().IsUnicode().HasMaxLength(100);
            builder.HasIndex(category => category.Title).IsUnique();

            builder.HasData(new Category(title: "Mobile"));
        }
    }
}