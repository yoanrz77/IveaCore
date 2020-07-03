using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
