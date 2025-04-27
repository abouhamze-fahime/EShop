using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customer;

public interface ICustomerRepository
{
    Task<Customer> GetByIdAsync(CustomerId customerId);
    Task AddAsync(Customer customer);
    Task UpdateAsync(Customer customer);
    Task DeleteAsync(CustomerId customerId);
}
