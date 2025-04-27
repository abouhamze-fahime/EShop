using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users;


// Prevent Inheritance – You don’t want other classes to extend or modify the behavior.
//Security & Stability – Protects critical classes from being misused or extended incorrectly.
//Improve Performance – The JIT compiler can optimize calls to methods in sealed classes better (since it knows they won't be overridden).
public sealed class User:Entity
{
    
    private User (Guid id ,    Name name):base(id)

    {
        Name = name;
    }
    public Name Name { get; private set; }

    public static User Create(Name name)
    {
        var user = new User(Guid.NewGuid(), name);
        user.Raise(new UserCreatedDomainEvent(user.Id));
        return user;
    }
}





