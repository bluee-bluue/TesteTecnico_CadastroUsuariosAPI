using System.ComponentModel.DataAnnotations;

namespace CadastroUsuariosAPI.Models.Entidade;

public class Usuario
{
    [Required(ErrorMessage = "O CPF é obrigatório")]
    public string Cpf { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
    [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres")]
    [RegularExpression(@"^[a-zA-Z\s]+$", // Regex para validar se o nome contém apenas letras e espaços
        ErrorMessage = "O nome deve conter apenas letras")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O email é obrigatório")]
    [RegularExpression(@"^[a-zA-Z0-9_.]+@[a-zA-Z]+\.[a-zA-Z]+$", // Regex para validar se o email tem o formato inicio@dominio.com
        ErrorMessage = "O email deve ser válido")]
    public string Email { get; set; }

    [Required(ErrorMessage = "O telefone é obrigatório")]
    [StringLength(11, ErrorMessage = "O telefone deve conter 11 dígitos")]
    [RegularExpression(@"^([1-9]{2})[9]{1}([0-9]{8})$", // Regex para validar se o telefone tem o formato xx9xxxxxxxx
        ErrorMessage = "O telefone deve iniciar com 9 após o DDD")]
    public string Telefone { get; set; }
}
