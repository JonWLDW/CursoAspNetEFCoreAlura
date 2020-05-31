using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			var livros = new List<Livro>
			{
				new Livro("001", "Quem Mexeu na Minha Query", 12.00M),
				new Livro("002", "Fique Rico com C#", 30.99M),
				new Livro("003", "Java Para Baixinhos", 25.99M)
			};

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapGet("/", async context =>
				{
					foreach (var livro in livros)
					{
						await context.Response.WriteAsync($"Código: {livro.Codigo, -10} Nome: {livro.Nome, -40}Valor: {livro.Preco, 10:F2}.\r\n");
					}
				});
			});
		}
	}
}
