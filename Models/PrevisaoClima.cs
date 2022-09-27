using System;
using System.ComponentModel.DataAnnotations;

namespace TempoClima.Models
{
    [Table("PrevisaoClima")]
    public class PrevisaoClima
    {
        [Key()]
        public int Id { get; set; }
        [ForeignKey("Cidade")]
        public int CidadeId { get; set; }
        public DateTime DataPrevisao { get; set; }
        public string Clima { get; set; }
        public decimal TemperaturaMinima { get; set; }
        public decimal TemperaturaMaxima { get; set; }
        public virtual Cidade Cidade { get; set; }
    }
}