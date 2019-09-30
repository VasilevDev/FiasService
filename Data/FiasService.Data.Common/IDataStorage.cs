using FiasService.Data.Common.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace FiasService.Data.Common
{
	public interface IDataStorage : IDisposable
	{
		DbSet<FiasAddressObject> AddressObjects { get; set; }
		DbSet<FiasHouse> Houses { get; set; }
		int SaveChanges();
	}
}
