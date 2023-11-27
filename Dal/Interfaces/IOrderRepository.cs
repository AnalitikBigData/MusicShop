using System;
using Domain.Entity;
namespace Dal.Interfaces
{
	public interface IOrderRepository : IBaseRepository<Order>
	{
        Order GetOrder(string order_name);
    }
}

