using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IVEACore.Models
{
    public class IndicatorSpecificity
    {
        [Key]
        [DisplayName("Indicator Specificity Id")]
        public int Id_IndicatorSpecificity { get; set; }

        [Required]
        [DisplayName("Indicator Id")]
        public int Id_Indicator { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Specificity")]
        public string Specificity { get; set; }

        [ForeignKey("Id_Indicator")]
        public Indicator Indicator { get; set; }

    }
}
