using System;
using Domain.Entity;
namespace Dal.Interfaces
{
	public interface ICustomerRepository : IBaseRepository<Customers>
	{
        Customers GetCustomer(string customer_name);
    }
}

