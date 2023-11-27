using System;
using Domain.Entity;
namespace Dal.Interfaces
{
	public interface IWarehouseRepository : IBaseRepository<Warehouses>
	{
        Warehouses GetWarehouse(string warehouse_name);
    }
}

