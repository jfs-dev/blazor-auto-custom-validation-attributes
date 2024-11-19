using System.ComponentModel.DataAnnotations;
using blazor_auto_custom_validation_attributes.Validators;

namespace blazor_auto_custom_validation_attributes.Models;

public class Customer
{
    [Required(ErrorMessage = "Favor informar o nome!")]
    [MinLength(3, ErrorMessage = "Favor informar pelo menos {1} caracteres!")]
    public string Nome { get; set; } = string.Empty;
    
    public bool ReceberNotificacao { get; set; }

    [Display(Name = "e-mail")]
    [RequiredIf("ReceberNotificacao", true, ErrorMessage = "Favor informar o e-mail!")]
    public string Email { get; set; } = string.Empty;
}
