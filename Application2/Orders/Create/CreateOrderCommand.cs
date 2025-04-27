using Domain.Customer;
using Domain.Order;
using MediatR;

namespace Application2.Orders.Create;


public sealed record CreateOrderCommand(Guid CustomerId) : IRequest;