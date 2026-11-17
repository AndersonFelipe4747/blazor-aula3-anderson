using System.ComponentModel.DataAnnotations;

namespace AulaApp1.Components.Models
{
    public class Categoria
    {
        [Required(ErrorMessage = "O nome da categoria é obrigatório.")]
        [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 letras.")]
        [RegularExpression(@"^[\p{L} ]+$", ErrorMessage = "O nome deve conter apenas letras e espaços.")]
        public string Nome { get; set; } = "";

        [Range(0, 100000, ErrorMessage = "A quantidade deve ficar entre 0 e 100000.")]
        public int Quantidade { get; set; }
    }
}