using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteEntity.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get;  set; }

        [Required(ErrorMessage = "O nome de usuário é obrigatório")]
        [StringLength(50, ErrorMessage = "O nome de usuário não pode exceder 50 caracteres")]
        public required string Nome { get;  set; }
       
        [Required(ErrorMessage = "O nome de Login é obrigatório")]
        [StringLength(50, ErrorMessage = "O nome de Login não pode exceder 50 caracteres")]
        public required string Login { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória")]
        [StringLength(100, ErrorMessage = "A senha não pode exceder 100 caracteres")]
        public required string Senha { get;  set; }

        [NotMappedAttribute]
        public bool RememberMe { get; set; }
        
        [NotMappedAttribute]
        public string? ReturnUrl { get; set; }
    }
}
