using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShopping.Domain.Model.Goods;

namespace OnlineShopping.Persistence.EF.Mapping.Goods
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(product => product.Code).IsRequired().IsUnicode().HasMaxLength(150);
            builder.HasIndex(product => product.Code).HasDatabaseName("Index_Code").IsUnique();

            builder.HasOne(product => product.Category).WithMany()
                .HasForeignKey(product => product.CategoryId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}