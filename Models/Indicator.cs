using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IVEACore.Models
{
    public class Indicator
    {
        [Key]
        [DisplayName("Indicador Id")]
        public int Id_Indicator { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Indicator Name")]
        public string NameIndicator { get; set; }

        [Required]
        [StringLength(10)]
        [DisplayName("Indicator Code")]
        public string CodeIndicator { get; set; }
    }
}
