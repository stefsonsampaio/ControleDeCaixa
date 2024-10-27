using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleDeCaixa.Model
{
    public class Transacoes
    {
        [Key]
        public int Transaca_id { get; set; }
        [Required]
        public int Caixa_id { get; set; }
        [ForeignKey("Caixa_id")]
        public Caixa? Id { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Data_transacao { get; set; } = DateTime.Now;
        [Required, StringLength(1)]
        public string Tipo_transacao { get; set; }
        [Required]
        public decimal valor_transacao { get; set; }
    }
}
