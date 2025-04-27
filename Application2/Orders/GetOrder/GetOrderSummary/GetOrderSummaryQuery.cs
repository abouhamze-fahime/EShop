using Domain.Order;
using MediatR;

namespace Application2.Orders.GetOrder.GetOrderSummary;

public record GetOrderSummaryQuery (Guid orderId) : IRequest<OrderSummary?>;

