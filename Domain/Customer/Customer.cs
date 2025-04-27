using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customer;

public class Customer
{
    /// <summary>
    /// setter is private to prevent changing these properties from outside the class
    /// we change them by exposing methods on our entity and when the application 
    /// layer calls then the respective changes apply
    /// </summary>
    public CustomerId Id { get; private set; }
    public string Email { get; private set; }=string.Empty;
    public string Name { get; private set; }=string.Empty;

    //private Customer(string email , string name)
    //{
    //    Id = new CustomerId(Guid.NewGuid());
    //    Email = email;
    //    Name = name;
    //}

    //public Customer Create(string email, string name)
    //{
    //    return new Customer(email, name);
    //}
}
