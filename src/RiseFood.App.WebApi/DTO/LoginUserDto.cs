using System.ComponentModel.DataAnnotations;

namespace RiseFood.App.WebAPi.DTO
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [StringLength(100, ErrorMessage = "O campo {0} tem que ter no minimo {2} caracteres e no maximo {1}.", MinimumLength = 4)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [StringLength(20, ErrorMessage = "O campo {0} tem que ter no minimo {2} caracteres e no maximo {1}.", MinimumLength = 6)]
        public string Password { get; set; }
    }
}