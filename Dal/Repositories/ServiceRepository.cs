using System;
using Dal.Interfaces;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Dal.Repositories
{
	public class ServiceRepository : IServiceRepository
	{
        ApplicationDBContext db;
		public ServiceRepository(ApplicationDBContext _db)
		{
            db = _db;
		}

        public bool Create(Services entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Services entity)
        {
            throw new NotImplementedException();
        }

        public Services Get(int id)
        {
            throw new NotImplementedException();
        }

        public Services GetService(string service_name)
        {
            throw new NotImplementedException();
        }

        public Task<List<Services>> Select()
        {
            return db.Service.ToListAsync();
        }
    }
}

