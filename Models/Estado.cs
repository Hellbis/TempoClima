using System.ComponentModel.DataAnnotations;

namespace TempoClima.Models
{
    [Table("Estado")]
    public class Estado
    {
        [Key()]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
    }
}