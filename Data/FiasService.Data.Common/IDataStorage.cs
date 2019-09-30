using FiasService.Data.Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace FiasService.Data.Common
{
	public interface IDataStorage
	{
		DbSet<FiasAddressObject> AddressObjects { get; set; }
		DbSet<FiasHouse> Houses { get; set; }
	}
}
