using Domain.Customer;
using Domain.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations;

internal class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id)
                  .HasConversion(
                    ProductId => ProductId.Value,
                    value => new ProductId(value));

        builder.Property(c => c.Sku)
             .HasConversion(
               sku => sku.Value,
               value =>  Sku.Create(value)!);

        builder.OwnsOne(p => p.Price, priceBuilder =>
        {
            priceBuilder.Property(p => p.Currency)
                .HasMaxLength(3);
        
        });
        
    }
}
