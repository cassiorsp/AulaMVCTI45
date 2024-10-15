using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeuPrimeiroAsp.Models
{
    public class RepresentanteModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome Representante")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome não pode exceder 100 caracteres")]
        public required string Nome { get; set; }

        [Display(Name = "Razão Social")]
        [Required(ErrorMessage = "A razão social é obrigatória")]
        [StringLength(150, ErrorMessage = "A razão social não pode exceder 150 caracteres")]
        public required string RazaoSocial { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve ter 11 caracteres")]
        public required string CPF { get; set; }

        [Required(ErrorMessage = "O CNPJ é obrigatório")]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "O CNPJ deve ter 14 caracteres")]
        public required string CNPJ { get; set; }

        [EmailAddress(ErrorMessage = "O e-mail não é válido")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório")]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "O telefone deve ter 14 caracteres")]
        [RegularExpression(@"^\d{14}$", ErrorMessage = "O telefone deve conter apenas números")]
        public required string Telefone { get; set; }

        [Required(ErrorMessage = "O celular é obrigatório")]
        [StringLength(15, MinimumLength = 15, ErrorMessage = "O celular deve ter 15 caracteres")]
        [RegularExpression(@"^\d{15}$", ErrorMessage = "O celular deve conter apenas números")]
        public required string Celular { get; set; }
    }
}
