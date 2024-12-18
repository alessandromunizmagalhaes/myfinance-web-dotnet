using System.ComponentModel.DataAnnotations;

namespace myfinance_web_dotnet.Models
{
    public class PlanoContaModel
    {
        public int? Id { get; set; }
        
        [Required(ErrorMessage = "Descrição é obrigatória")]
        public required string Nome { get; set; }
        
        [Required(ErrorMessage = "{0} é obrigatório")]
        public required string Tipo { get; set; }
    }
}