using Application2.Data1;
using Domain.Order;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application2.Orders.GetOrder.GetOrderSummary;

internal sealed  class GetOrderSummaryQueryHandler :IRequestHandler<GetOrderSummaryQuery , OrderSummary>
{
    private readonly IApplicationDbContext _context;
    public GetOrderSummaryQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<OrderSummary?> Handle(GetOrderSummaryQuery request, CancellationToken cancellationToken)
    {
       return await _context.OrderSummaries
            .FirstOrDefaultAsync(x => x.Id == request.orderId, cancellationToken);
    }
}

