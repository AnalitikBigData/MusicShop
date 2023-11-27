using System;
using Domain.Entity;
namespace Dal.Interfaces
{
	public interface IInstrumentRepository : IBaseRepository<Instruments>
	{
        Instruments GetInstrument(string instrument_name);
    }
}

