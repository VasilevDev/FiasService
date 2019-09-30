using FiasService.Data.Common;
using System;

namespace FiasService.Database
{
	public class DataStorageFactory : IDataStorageFactory
	{
		private readonly Func<IDataStorage> contextCreator;

		public DataStorageFactory(Func<IDataStorage> contextCreator)
		{
			this.contextCreator = contextCreator;
		}

		public IDataStorage Create()
		{
			return contextCreator?.Invoke();
		}
	}
}
