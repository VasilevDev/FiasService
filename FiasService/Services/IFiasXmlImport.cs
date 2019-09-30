using FiasService.Contract;

namespace FiasService.Services
{
	public interface IFiasXmlImport<T>
	{
		BaseResult<T> Import(string src);
	}
}
