using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace cursoAspNetEfCoreAlura
{
	public interface IRelatorioDeLivros
	{
		ICatalogoDeLivros CatalogoDeLivros { get; }

		Task Imprimir(HttpContext context);
	}
}