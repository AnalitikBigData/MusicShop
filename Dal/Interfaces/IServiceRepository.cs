using System;
using Domain.Entity;
namespace Dal.Interfaces
{
	public interface IServiceRepository : IBaseRepository<Services>
	{
        Services GetService(string service_name);
    }
}

