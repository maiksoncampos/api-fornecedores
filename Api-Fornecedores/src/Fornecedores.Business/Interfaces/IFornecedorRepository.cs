using Fornecedores.Business.Models;

namespace Fornecedores.Business.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEnderecos(Guid id);
        Task<IEnumerable<Fornecedor>> Buscar(FiltroFornecedor filtro);
    }
}
