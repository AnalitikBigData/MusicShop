using System;
using Dal.Interfaces;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Dal.Repositories
{
	public class Order_lineRepository : IOrder_lineRepository
	{
        private readonly ApplicationDBContext db;
		public Order_lineRepository(ApplicationDBContext _db)
		{
            db = _db;
		}

        

        public bool Create(Order_lines entity)
        {
            throw new NotImplementedException();
        }

        

        public bool Delete(Order_lines entity)
        {
            throw new NotImplementedException();
        }

        public Order Get(int id)
        {
            throw new NotImplementedException();
        }

        

        public Order_lines GetOrderLine(string orderLine_name)
        {
            throw new NotImplementedException();
        }

        

        Order_lines IBaseRepository<Order_lines>.Get(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Order_lines>> IBaseRepository<Order_lines>.Select()
        {
            return db.Order_lines.ToListAsync();
        }
    }
}

