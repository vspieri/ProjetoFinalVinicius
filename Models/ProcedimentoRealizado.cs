using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalVinicius.Models
{
    [Table("ProcedimentoRealizado")]
    public class ProcedimentoRealizado
    {
        [Column("ProcedimentoRealizadoId")]
        [Display(Name = " Código do ProcedimentoRealizado")]
        public int ProcedimentoRealizadoId { get; set; }



        [ForeignKey("ClienteId")]
        public int? ClienteId { get; set; }

        public Cliente? Cliente { get; set; }


        [ForeignKey("ProcedimentoId")]
        public int? ProcedimentoId { get; set; }

        public Procedimento? Procedimento { get; set; }


        [ForeignKey("ColaboradorId")]
        public int? ColaboradorId { get; set; }

        public Colaborador? Colaborador { get; set; }

        [ForeignKey("LocalRealizacaoId")]
        public int? LocalRealizacaoId { get; set; }

        public LocalRealizacao? LocalRealizacao { get; set; }

        [Column("DataRealizadoId")]
        [Display(Name = " Código do DataRealizado")]
        public DateTime DataRealizadoId { get; set; }

        [Column("ObservacaoRealizadoId")]
        [Display(Name = " Código do ObservacaoRealizado")]
        public string ObservacaoRealizadoId { get; set; }
    }
}
