using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalVinicius.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        [Column("CidadeId")]
        [Display(Name = " Código da Cidade")]
        public int CidadeId { get; set; }

        [Column("NomeCidade")]
        [Display(Name = "Nome da Cidade")]
        public string NomeCidade { get; set; } = string.Empty;

        [ForeignKey("EstadoId")]
        public int EstadoId { get; set; }

        public Estado? Estado { get; set; }
    }
}
