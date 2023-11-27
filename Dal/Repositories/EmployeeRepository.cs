using System;
using Dal.Interfaces;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Dal.Repositories
{
	public class EmployeeRepository : IEmployeeRepository
	{
        private readonly ApplicationDBContext db;
		public EmployeeRepository(ApplicationDBContext _db)
		{
            db = _db;
		}

        public bool Create(Employees entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Employees entity)
        {
            throw new NotImplementedException();
        }

        public Employees Get(int id)
        {
            throw new NotImplementedException();
        }

        public Employees GetEmployee(string employee_name)
        {
            throw new NotImplementedException();
        }

        public Task<List<Employees>> Select()
        {
            return db.Employee.ToListAsync();
        }
    }
}

