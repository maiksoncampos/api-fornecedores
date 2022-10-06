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

        public async Task<IEnumerable<Fornecedor>> Buscar(FiltroFornecedor filtro)
        {
            var qry = Db.Fornecedores.AsQueryable();

            if (!string.IsNullOrEmpty(filtro.Nome))
                qry = qry.Where(x => x.Nome.Contains(filtro.Nome));

            if (!string.IsNullOrEmpty(filtro.CNPJ))
                qry = qry.Where(x => x.CNPJ.Equals(filtro.CNPJ));

            if (!string.IsNullOrEmpty(filtro.Cidade))
                qry = qry.Where(x => x.Enderecos.Any( c => c.Cidade.Contains(filtro.Cidade)));

            return await qry.AsNoTracking()
                .Include(c => c.Enderecos)
                .ToListAsync();
        }

    }
}
