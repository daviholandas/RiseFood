using System.ComponentModel.DataAnnotations;

namespace RiseFood.App.WebAPi.DTO
{
    public class UserDto
    {
        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [StringLength(100, ErrorMessage = "O campo {0} tem que ter no minimo {2} caracteres e no maximo {1}.", MinimumLength = 4)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [EmailAddress(ErrorMessage = "O campo {0}  está em um formato invalido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [StringLength(20, ErrorMessage = "O campo {0} tem que ter no minimo {2} caracteres e no maximo {1}.", MinimumLength = 6)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "As senhas não conferem.")]
        public string ComparePassword { get; set; }
    }
}