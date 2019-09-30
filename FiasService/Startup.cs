using System;
using FiasService.Data.Common;
using FiasService.Data.Postgres;
using FiasService.Enums;
using FiasService.Settings;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace FiasService
{
	public class Startup
	{
		private readonly string connectionString;
		private ILoggerFactory loggerFactory;
		private ServiceProvider sp;
		private IFiasSettings settings;

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
			connectionString = Configuration.GetConnectionString("DefaultConnection");
			settings = FiasServiceSettingsCreate();
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			this.sp = services.BuildServiceProvider();
			this.loggerFactory = this.sp.GetService<ILoggerFactory>();

			services.AddMvc()
				.SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

			// Запустим миграции базы данных
			using (var context = DataStorageCreator())
			{
				context.Database.Migrate();
			}

			sp = services.BuildServiceProvider();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseMvc();
		}

		private DataStorageBase DataStorageCreator()
		{
			var optionsBuilder = new DbContextOptionsBuilder<DataStorageBase>();

			switch (settings.DatabaseProvider)
			{
				case DatabaseProviderEnum.Postgres:
					optionsBuilder.UseNpgsql(connectionString);
					return new PostgresDataStorage(loggerFactory, optionsBuilder.Options, connectionString);
				default:
					throw new Exception("Unknown database provider! Only Postgres and Oracle supported");
			}
		}

		private IFiasSettings FiasServiceSettingsCreate()
		{
			if (settings != null) return settings;

			settings = new FiasSettings();
			Configuration.GetSection("FiasService").Bind(settings);
			return settings;
		}
	}
}
