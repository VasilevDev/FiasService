using FiasService.Enums;

namespace FiasService.Settings
{
	public class FiasSettings : IFiasSettings
	{
		public DatabaseProviderEnum DatabaseProvider { get; set; }
	}
}
