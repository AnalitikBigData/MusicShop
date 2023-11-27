using System;
using Dal.Interfaces;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Dal.Repositories
{
	public class OrderRepository : IOrderRepository
	{
        ApplicationDBContext db;
		public OrderRepository(ApplicationDBContext _db)
		{
            db = _db;
		}

        public bool Create(Order entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Order entity)
        {
            throw new NotImplementedException();
        }

        public Order Get(int id)
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(string order_name)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> Select()
        {
            return db.Order.ToListAsync();
        }
    }
}

