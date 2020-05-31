using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace cursoAspNetEfCoreAlura
{
	public class RelatorioDeLivros : IRelatorioDeLivros
	{
		public ICatalogoDeLivros CatalogoDeLivros { get; private set; }

		public RelatorioDeLivros(ICatalogoDeLivros catalogoDeLivros)
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