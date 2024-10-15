using System.ComponentModel.DataAnnotations;
using TesteEntity.Models;

namespace MeuPrimeiroAsp.Models
{
    public class ClienteModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres")]
        [Display(Name = "Nome Cliente")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve ter 11 dígitos")]
        public required string CPF { get; set; }

        [Required(ErrorMessage = "O email é obrigatório")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório")]
        [Phone(ErrorMessage = "Telefone inválido")]
        public required string Telefone { get; set; }

        [Required(ErrorMessage = "O endereço é obrigatório")]
        public required string Endereco { get; set; }

        [Required(ErrorMessage = "A cidade é obrigatória")]
        public required string Cidade { get; set; }

        [Required(ErrorMessage = "O estado é obrigatório")]
        public required string Estado { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "A data de nascimento é obrigatória")]
        public DateTime DataNascimento { get; set; }

        [Range(0, 1, ErrorMessage = "Status deve ser 0 (Inativo) ou 1 (Ativo)")]
        public int Status { get; set; }
        public int UsuarioId { get; set; }
        public required Usuario Usuario { get; set; }
    }
}
