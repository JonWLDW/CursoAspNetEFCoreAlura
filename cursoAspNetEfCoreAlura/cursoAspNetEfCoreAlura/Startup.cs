using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace cursoAspNetEfCoreAlura
{
	public class Startup
	{
		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddScoped<ICatalogoDeLivros, CatalogoDeLivros>();
			services.AddScoped<IRelatorioDeLivros, RelatorioDeLivros>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseRouting();

			//var catalogo = serviceProvider.GetService<ICatalogoDeLivros>();
			var relatorio = serviceProvider.GetService<IRelatorioDeLivros>();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapGet("/", async context =>
				{
					await relatorio.Imprimir(context);
				});
			});
		}
	}
}
