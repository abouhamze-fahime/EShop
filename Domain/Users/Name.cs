using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users;

//value object 
public sealed record Name
{

    public Name(string? value)
    {
          ArgumentNullException.ThrowIfNullOrEmpty(value);
      //  Ensure.NotNullOrEmpty(value);
        Value = value;
    }
    public string Value { get; }
}


public static class Ensure
{
    public static void NotNullOrEmpty( 
       [NotNull] string? value,
        [CallerArgumentExpression("value")] string? argumentName = null)
        
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentNullException(nameof(value));
    }
}

