using System;
using Dal.Interfaces;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Dal.Repositories
{
	public class FactoryRepository : IFactoryRepository
	{
        private readonly ApplicationDBContext db;
		public FactoryRepository(ApplicationDBContext _db)
		{
            db = _db;
		}

        public bool Create(Factories entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Factories entity)
        {
            throw new NotImplementedException();
        }

        public Factories Get(int id)
        {
            throw new NotImplementedException();
        }

        public Factories GetFactories(string factory_name)
        {
            throw new NotImplementedException();
        }

        public Task<List<Factories>> Select()
        {
            return db.Factories.ToListAsync();
        }
    }
}

