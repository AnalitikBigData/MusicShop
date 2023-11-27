using System;
using Domain.Entity;
namespace Dal.Interfaces
{
	public interface IOrder_lineRepository : IBaseRepository<Order_lines>
	{
        Order_lines GetOrderLine(string orderLine_name);
    }
}

