using System;
using Dal.Interfaces;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Dal.Repositories
{
	public class CustomerRepository : ICustomerRepository
	{
        ApplicationDBContext db;
		public CustomerRepository(ApplicationDBContext _db)
		{
            db = _db;
		}

        public bool Create(Customers entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Customers entity)
        {
            throw new NotImplementedException();
        }

        public Customers Get(int id)
        {
            throw new NotImplementedException();
        }

        public Customers GetCustomer(string customer_name)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customers>> Select()
        {
            return db.Customer.ToListAsync();
        }
    }
}

