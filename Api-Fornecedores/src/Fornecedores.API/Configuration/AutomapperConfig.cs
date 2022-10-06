using AutoMapper;
using Fornecedores.API.ViewModels;
using Fornecedores.Business.Models;

namespace Fornecedores.API.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
        }
    }
}
