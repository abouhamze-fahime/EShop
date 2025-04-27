using Application2.Data1;
using Domain.Customer;
using Domain.Order;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application2.Orders.Create
{
    internal sealed class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand>
    {
        private readonly IApplicationDbContext _context;
        public CreateOrderCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var customer = await _context.Customers
                .FindAsync(new CustomerId (request.CustomerId));

            if (customer == null) return;

            var order = Order.Create(customer.Id);
            _context.Orders.Add(order);

            _context.OrderSummaries.Add(new OrderSummary(order.Id.Value, customer.Id.Value, 0));

            await _context.SaveChangesAsync(cancellationToken);
          //  await _bus.Send(new OrderCreateEvent(order.Id.Value));


        }
  

    }
}
