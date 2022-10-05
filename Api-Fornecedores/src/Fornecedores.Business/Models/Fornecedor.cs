namespace Fornecedores.Business.Models
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public IEnumerable<Endereco> Enderecos { get; set; }
    }
}