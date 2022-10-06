using Fornecedores.Business.Interfaces;
using Fornecedores.Business.Models;
using Fornecedores.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Fornecedores.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(FornecedoresDbContext context) : base(context)
        {
        }

        public async Task<Fornecedor> ObterFornecedorEnderecos(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(c => c.Enderecos)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
