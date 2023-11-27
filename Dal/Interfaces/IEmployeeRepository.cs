using System;
using Domain.Entity;
namespace Dal.Interfaces
{
	public interface IEmployeeRepository : IBaseRepository<Employees>
	{
        Employees GetEmployee(string employee_name);
    }
}

