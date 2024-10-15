using System;
using System.ComponentModel.DataAnnotations;

namespace RevisaoMvc.Models
{
    public class FornecedorModel
    {
        // ID do fornecedor
        public int Id { get; set; }

        // Nome do fornecedor - Obrigatório, limite de 100 caracteres
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; }

        // CNPJ do fornecedor - Obrigatório, limite de 14 caracteres (Formato brasileiro de CNPJ)
        [Required(ErrorMessage = "O CNPJ é obrigatório.")]
        [StringLength(14, ErrorMessage = "O CNPJ deve ter 14 caracteres.")]
        public string CNPJ { get; set; }

        // Endereço do fornecedor - Obrigatório, limite de 200 caracteres
        [Required(ErrorMessage = "O endereço é obrigatório.")]
        [StringLength(200, ErrorMessage = "O endereço deve ter no máximo 200 caracteres.")]
        public string Endereco { get; set; }

        // Cidade do fornecedor - Obrigatório, limite de 100 caracteres
        [Required(ErrorMessage = "A cidade é obrigatória.")]
        [StringLength(100, ErrorMessage = "A cidade deve ter no máximo 100 caracteres.")]
        public string Cidade { get; set; }

        // Estado do fornecedor - Obrigatório, limite de 2 caracteres (sigla do estado, ex: SP)
        [Required(ErrorMessage = "O estado é obrigatório.")]
        [StringLength(2, ErrorMessage = "O estado deve ter 2 caracteres.")]
        public string Estado { get; set; }

        // Data de Cadastro - Obrigatória
        [Required(ErrorMessage = "A data de cadastro é obrigatória.")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido.")]
        public DateTime DataCadastro { get; set; }

        // Telefone do fornecedor - Obrigatório, limite de 15 caracteres (incluindo máscara)
        [Required(ErrorMessage = "O telefone é obrigatório.")]
        [StringLength(15, ErrorMessage = "O telefone deve ter no máximo 15 caracteres.")]
        [Phone(ErrorMessage = "Número de telefone inválido.")]
        public string Telefone { get; set; }
    }
}
