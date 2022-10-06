using Fornecedores.Business.Interfaces;
using Fornecedores.Business.Models;
using Fornecedores.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Fornecedores.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(FornecedoresDbContext context) : base(context) { }

        public async Task<IEnumerable<Endereco>> ObterEnderecosPorFornecedor(Guid fornecedorId)
        {
            return await Buscar(p => p.FornecedorId == fornecedorId);
        }
    }
}
