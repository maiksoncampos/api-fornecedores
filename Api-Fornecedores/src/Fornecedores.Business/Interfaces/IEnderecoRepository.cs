using Fornecedores.Business.Models;

namespace Fornecedores.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<IEnumerable<Endereco>> ObterEnderecosPorFornecedor(Guid fornecedorId);
    }
}
