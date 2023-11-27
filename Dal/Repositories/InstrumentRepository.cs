using System;
using Dal.Interfaces;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Dal.Repositories
{
	public class InstrumentRepository : IInstrumentRepository
	{
        private readonly ApplicationDBContext db;
		public InstrumentRepository(ApplicationDBContext _db)
		{
            db = _db;
		}

        public bool Create(Instruments entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Instruments entity)
        {
            throw new NotImplementedException();
        }

        public Instruments Get(int id)
        {
            throw new NotImplementedException();
        }

        public Instruments GetInstrument(string instrument_name)
        {
            throw new NotImplementedException();
        }

        public Task<List<Instruments>> Select()
        {
            return db.Instrument.ToListAsync();
        }
    }
}

