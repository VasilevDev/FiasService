using FiasService.Contract;
using System;
using System.Collections.Generic;

namespace FiasService.Database
{
	public interface IFiasRepository
	{
		BaseResult<Guid> Add(string tableName, IDictionary<string, string> fields);
	}
}
