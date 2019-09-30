using FiasService.Enums;

namespace FiasService.Settings
{
	public interface IFiasSettings
	{
		DatabaseProviderEnum DatabaseProvider { get; set; }
	}
}
