﻿using System.ComponentModel.DataAnnotations;

namespace Fornecedores.API.ViewModels
{
    public class FornecedorViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]

        public string CNPJ { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public IEnumerable<EnderecoViewModel> Enderecos { get; set; }
    }
}
