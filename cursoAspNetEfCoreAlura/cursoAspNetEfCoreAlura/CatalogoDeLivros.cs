using System.Collections.Generic;

namespace cursoAspNetEfCoreAlura
{
	public class CatalogoDeLivros
	{
		public List<Livro> RetornarLivros()
		{
			return new List<Livro>
			{
				new Livro("001", "Quem Mexeu na Minha Query", 12.00M),
				new Livro("002", "Fique Rico com C#", 30.99M),
				new Livro("003", "Java Para Baixinhos", 25.99M)
			};
		}
	}
}