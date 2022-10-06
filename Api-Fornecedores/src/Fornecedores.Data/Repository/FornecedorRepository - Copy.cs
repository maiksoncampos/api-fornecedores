using Fornecedores.Business.Interfaces;
using Fornecedores.Business.Models;
using Fornecedores.Data.Context;

namespace Fornecedores.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(FornecedoresDbContext context) : base(context)
        {
        }
    }
}
