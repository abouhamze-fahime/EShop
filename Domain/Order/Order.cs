﻿using Domain.Customer;
using Domain.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Domain.Order;

public class Order
{
    private readonly HashSet<LineItem> _lineItems = new();
    private Order()
    {
        // private constructor to prevent instantiation from outside
    }
    public OrderId Id { get; private set; }
    public CustomerId CustomerId { get; private set; }

    public IReadOnlyList<LineItem> LineItems => _lineItems.ToList();
    public static Order Create(CustomerId customerId)
    {
        var order = new Order
        {
            Id = new OrderId( Guid.NewGuid()),
            CustomerId = customerId,
        };

        return order;
    }

    public void Add (ProductId productId , Money price)
    {
        var lineItem = new LineItem(new LineItemId( Guid.NewGuid()), Id, productId, price);
        _lineItems.Add(lineItem);
    }


    public void RemoveLineItem(LineItemId lineItemId)
    {
        var lineItem = _lineItems.FirstOrDefault(x => x.Id == lineItemId);
        if (lineItem == null) return;
           // throw new InvalidOperationException("Line item not found");
        _lineItems.Remove(lineItem);
    }

}




