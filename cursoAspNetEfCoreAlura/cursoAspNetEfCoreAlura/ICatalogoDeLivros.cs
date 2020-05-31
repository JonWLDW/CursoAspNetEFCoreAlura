using System.Collections.Generic;

namespace cursoAspNetEfCoreAlura
{
	public interface ICatalogoDeLivros
	{
		List<Livro> RetornarLivros();
	}
}