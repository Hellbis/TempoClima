using System.ComponentModel.DataAnnotations;

namespace TempoClima.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        [Key()]
        public int Id { get; set; }
        public string Nome { get; set; }
        [ForeignKey("Estado")]
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }
    }
}