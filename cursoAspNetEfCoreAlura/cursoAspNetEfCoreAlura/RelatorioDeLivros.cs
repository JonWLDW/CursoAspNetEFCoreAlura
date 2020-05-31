using Microsoft.AspNetCore.Http;
using System.Reflection;
using System.Threading.Tasks;

namespace cursoAspNetEfCoreAlura
{
	public class RelatorioDeLivros
	{
		public CatalogoDeLivros CatalogoDeLivros { get; private set; }
	
		public RelatorioDeLivros(CatalogoDeLivros catalogoDeLivros)
		{
			CatalogoDeLivros = catalogoDeLivros;
		}

		public async Task Imprimir(HttpContext context)
		{
			foreach (var livro in CatalogoDeLivros.RetornarLivros())
			{
				await context.Response.WriteAsync($"Código: {livro.Codigo,-10} Nome: {livro.Nome,-40}Valor: {livro.Preco,10:F2}.\r\n");
			}
		}
	}
}