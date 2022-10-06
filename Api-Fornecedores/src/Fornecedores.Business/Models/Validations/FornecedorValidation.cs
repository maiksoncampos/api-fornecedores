using FluentValidation;
using Fornecedores.Business.Models.Validations.Documentos;

namespace Fornecedores.Business.Models.Validations
{
    public class FornecedorValidation : AbstractValidator<Fornecedor>
    {
        public FornecedorValidation()
        {
            RuleFor(f => f.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 100)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
           
            RuleFor(f => f.CNPJ.Length).Equal(CnpjValidacao.TamanhoCnpj)
                .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}.");

            RuleFor(f => CnpjValidacao.Validar(f.CNPJ)).Equal(true)
                .WithMessage("O documento fornecido é inválido.");

            RuleFor(f => f.Email).EmailAddress()
                .WithMessage("O e-mail fornecido é inválido.");
        }
    }
}
