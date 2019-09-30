using FiasService.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FiasService.Data.Postgres
{
	public class PostgresDataStorage : DataStorageBase
	{
		private readonly ILoggerFactory loggerFactory;
		private readonly ILogger<PostgresDataStorage> log;
		private readonly string connectionString;
		private string designTimeConnectionString =
			"Host=localhost;Port=5432;Database=fiasservice;Username=postgres;Password=password";

		#region Конструкторы
		public PostgresDataStorage()
		{

		}

		public PostgresDataStorage(DbContextOptions options)
			: base(options)
		{
		}

		public PostgresDataStorage(ILoggerFactory loggerFactory, DbContextOptions options, string connectionString)
		{
			this.loggerFactory = loggerFactory;
			if (loggerFactory != null)
				this.log = loggerFactory.CreateLogger<PostgresDataStorage>();
			this.connectionString = connectionString;
		}
		#endregion

		// Design Time Factory method
		public PostgresDataStorage CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<DataStorageBase>();
			optionsBuilder.UseNpgsql(designTimeConnectionString);

			return new PostgresDataStorage(loggerFactory, optionsBuilder.Options, connectionString);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql(string.IsNullOrEmpty(connectionString) ? designTimeConnectionString : connectionString);
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.HasPostgresExtension("uuid-ossp");
		}
	}
}
