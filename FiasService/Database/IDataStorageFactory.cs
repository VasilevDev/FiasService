using FiasService.Data.Common;
using System;

namespace FiasService.Database
{
	public interface IDataStorageFactory
	{
		IDataStorage Create();
	}
}
