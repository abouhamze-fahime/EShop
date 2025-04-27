using Domain.Order;
using MediatR;
using System.Windows.Input;

namespace Application.Orders.RemoveLineItem;

public record RemmoveLineItemCommand(OrderId orderId , LineItemId lineItemId ): IRequest;

