using System.ComponentModel.DataAnnotations;

namespace AulaApp1.Components.Models
{
    public class Produto
    {
        [Required(ErrorMessage = "O nome do produto é obrigatório.")]
        public string Nome { get; set; } = "";

        [Range(0.01, 1000000, ErrorMessage = "O preço deve ser maior que zero.")]
        public decimal Preco { get; set; }

        public int Quantidade { get; set; }
    }
}