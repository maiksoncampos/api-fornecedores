using Fornecedores.Business.Interfaces;
using Fornecedores.Business.Models;
using Fornecedores.Data.Context;

namespace Fornecedores.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(FornecedoresDbContext context) : base(context) { }
    }
}
