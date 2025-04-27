namespace Domain.Order;

public record OrderSummary(Guid Id , Guid CustomerId , decimal totalPrice);

