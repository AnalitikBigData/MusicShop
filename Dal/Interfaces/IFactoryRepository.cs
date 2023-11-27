using System;
using Domain.Entity;
namespace Dal.Interfaces
{
	public interface IFactoryRepository : IBaseRepository<Factories>
	{
        Factories GetFactories(string factory_name);
    }
}

