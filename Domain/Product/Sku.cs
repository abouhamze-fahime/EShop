using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Product;

//sku is a value object: stock keeping unit
// the thing that we can do with value object is to enforce some constraints 
// by encapsulating how the object can be created
//for sku we want to follow a certain format that the value of the sku has to follow
// record is immutable by default
public record Sku
{
    private const int SkuLength = 15; //sku length is 15 characters
    //factory method
    private Sku(string value) => Value = value;
    // init , as soon as the value is set, it cannot be changed or modified
    public string Value { get; init; }

    // Sku.Create
    public static Sku? Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return null;
        if (value.Length != SkuLength)
            return null;
        if (!value.All(char.IsDigit))
            return null;
        return new Sku(value);
    }
}
