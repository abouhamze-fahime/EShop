using Application.Orders.RemoveLineItem;
using Application2.Data1;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace Application2.Orders.RemoveLineItem;

internal sealed class RemoveLineItemCommandHandler : IRequestHandler<RemmoveLineItemCommand>
{
    private readonly IApplicationDbContext  _context;
    public RemoveLineItemCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task Handle(RemmoveLineItemCommand request, CancellationToken cancellationToken)
    {
        var order = await _context.Orders
            .Include(x => x.LineItems.Where(li=>li.Id==request.lineItemId))
            .SingleOrDefaultAsync(x => x.Id == request.orderId, cancellationToken);

        if (order == null) return;
        order.RemoveLineItem(request.lineItemId);
       await _context.SaveChangesAsync();

    }

}

