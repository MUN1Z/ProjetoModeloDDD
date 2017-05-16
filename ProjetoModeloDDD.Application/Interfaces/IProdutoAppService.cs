using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Application.Interfaces
{
    public interface IProdutoAppService: IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
