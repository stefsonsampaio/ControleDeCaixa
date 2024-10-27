using System.ComponentModel.DataAnnotations;

namespace ControleDeCaixa.Model
{
    public class Caixa
    {
        public int Id { get; set; }
        [Required]
        public decimal Valor_inicial { get; set; }
        public decimal? Valor_final {  get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Data_abertura { get; set; } = DateTime.Now;
        [DataType(DataType.DateTime)]
        public DateTime? Data_fechamento { get; set; }
        [StringLength(1)]
        public string? Status { get; set; }
        [StringLength(200)]
        public string? Justificativa { get; set; }
    }
}
