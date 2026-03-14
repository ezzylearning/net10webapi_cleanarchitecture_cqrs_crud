using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using MyShop.Domain.Products;

namespace MyShop.Infrastructure.Domain.Products
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Table Name
            builder.ToTable("Products");

            // Primary Key
            builder.HasKey(p => p.ProductId);

            // Properties
            builder.Property(p => p.ProductId)
                .HasColumnName("ProductID"); 

            builder.Property(p => p.ProductName)
                .IsRequired()
                .HasMaxLength(40);

            builder.Property(p => p.QuantityPerUnit)
                .HasMaxLength(20);

            builder.Property(p => p.UnitPrice)
                .HasColumnType("money"); // Matches SQL Server money type

        }
    }
}
