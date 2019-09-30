using FiasService.Data.Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace FiasService.Data.Common
{
	public abstract class DataStorageBase : DbContext, IDataStorage
	{
		protected DataStorageBase()
		{

		}

		protected DataStorageBase(DbContextOptions options)
			: base(options)
		{

		}

		public virtual DbSet<FiasAddressObject> AddressObjects { get; set; }
		public virtual DbSet<FiasHouse> Houses { get; set; }
	}
}
