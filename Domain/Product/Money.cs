using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Product;


//if an object identify by values, we call that a value object
// two value objects are equal if they have the same values in this case values are currency and amount so 
// two money objects are equal if they have the same amount and currency
public record Money(decimal Amount, string Currency)
{
    public decimal Amount { get; init; } = Amount;
    public string Currency { get; init; } = Currency;
    //private Money() { }

    //public Money(decimal amount, string currency)
    //{
    //    Amount = amount;
    //    Currency = currency;
    //}
    public override string ToString()
    {
        return $"{Amount} {Currency}";
    }
}
