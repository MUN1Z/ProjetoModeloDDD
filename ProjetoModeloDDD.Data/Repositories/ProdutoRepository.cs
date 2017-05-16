using System.Collections.Generic;
using System.Linq;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;

namespace ProjetoModeloDDD.Data.Repositories
{
    public class ProdutoRepository: RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produto.Where(p => p.Nome.Contains(nome));
        }
    }
}
