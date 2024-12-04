using DemoStore.WebUI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace DemoStore.WebUI
{
    public class TblProductEntityTypeConfiguration : IEntityTypeConfiguration<TblProduct>
    {
        public void Configure(EntityTypeBuilder<TblProduct> builder)
        {
            builder
                .HasKey(x => x.ProductId);

            builder
                .HasOne(x => x.Category)
                .WithMany(x => x.Categories)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Property(x => x.ProductId)
                .HasColumnName("ProductId")
                .HasPrecision(10, 0);

            builder
                .Property(x => x.ProductName)
                .HasColumnName("ProductName")
                .IsUnicode(true);

            builder
                .Property(x => x.ProductPrice)
                .HasColumnName("ProductPrice")
                .HasPrecision(18, 2);

            builder
                .Property(x => x.ProductStock)
                .HasColumnName("ProductStock")
                .HasPrecision(10, 0);

            builder
                .Property(x => x.ProductStatus)
                .HasColumnName("ProductStatus");

            builder
                .ToTable("TblProduct", "dbo");
        }
    }
}
