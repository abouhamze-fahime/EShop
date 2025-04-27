using Domain.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Order;
public class LineItem
{
    private LineItem() { }
    internal LineItem(LineItemId id, OrderId orderId, ProductId productId, Money price)
    {
        Id = id;
        OrderId = orderId;
        ProductId = productId;
        Price = price;
    }
    public LineItemId Id { get; private set; }
    public OrderId OrderId { get; set; }
    public ProductId ProductId { get; private set; }
    public Money Price { get; private set; }
}
