using Domain.Order;
using Domain.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations;

internal class LineItemConfiguration : IEntityTypeConfiguration<Domain.Order.LineItem>
{
    public void Configure(EntityTypeBuilder<LineItem> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id)
       .HasConversion(
        lineItemId => lineItemId.Value,
        value => new LineItemId(value));
        builder.HasOne<Product>()
             .WithMany()
            .HasForeignKey(c => c.ProductId)
            .IsRequired();

        builder.OwnsOne(li => li.Price);

       

 

}
}
