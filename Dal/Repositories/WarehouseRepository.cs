using System;
using Dal.Interfaces;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Dal.Repositories
{
	public class WarehouseRepository : IWarehouseRepository
	{
        private readonly ApplicationDBContext db;
		public WarehouseRepository(ApplicationDBContext _db)
		{
            db = _db;
		}

        public bool Create(Warehouses entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Warehouses entity)
        {
            throw new NotImplementedException();
        }

        public Warehouses Get(int id)
        {
            throw new NotImplementedException();
        }

        public Warehouses GetWarehouse(string warehouse_name)
        {
            throw new NotImplementedException();
        }

        public Task<List<Warehouses>> Select()
        {
            return db.Warehouse.ToListAsync();
        }
    }
}

