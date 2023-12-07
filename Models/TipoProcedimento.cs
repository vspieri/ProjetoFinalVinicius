using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalVinicius.Models
{
    [Table("TipoProcedimento")]
    public class TipoProcedimento
    {

        [Column("TipoProcedimentoId")]
        [Display(Name = "Código do Tipo Procedimento")]
        public int TipoProcedimentoId { get; set; }

        [Column("TipoProcedimentoNome")]
        [Display(Name = "Nome do TipoProcedimento")]
        public string TipoProcedimentoNome { get; set; } = string.Empty;
    }
}
