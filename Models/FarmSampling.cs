using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IVEACore.Models
{
    public class FarmSampling
    {
        [Key]
        [DisplayName("Id Farm Sampling")]
        public int Id_FamSampling { get; set; }

        [Required]
        [DisplayName("Id Farm")]
        public int Id_Farm { get; set; }

        [Required]
        [DisplayName("Date Sampling")]
        public DateTime DateSampling { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Details")]
        public string Details { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Description CFV")]
        public string Description_CFV { get; set; }
        [Required]
        [DisplayName("Value CFV")]
        public float Value_CFV { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Description DAS")]
        public string Description_DAS { get; set; }
        [Required]
        [DisplayName("Value DAS")]
        public float Value_DAS { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Description DFS")]
        public string Description_DFS { get; set; }
        [Required]
        [DisplayName("Value DFS")]
        public float Value_DFS { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Description MPE")]
        public string Description_MPE { get; set; }
        [Required]
        [DisplayName("Value MPE")]
        public float Value_MPE { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Description NCS")]
        public string Description_NCS { get; set; }
        [Required]
        [DisplayName("Value NCS")]
        public float Value_NCS { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Description NES")]
        public string Description_NES { get; set; }
        [Required]
        [DisplayName("Value NES")]
        public float Value_NES { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Description NRS")]
        public string Description_NRS { get; set; }
        [Required]
        [DisplayName("Value NRS")]
        public float Value_NRS { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Description PES")]
        public string Description_PES { get; set; }
        [Required]
        [DisplayName("Value PES")]
        public float Value_PES { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Description RCES")]
        public string Description_RCES { get; set; }
        [Required]
        [DisplayName("Value RCES")]
        public float Value_RCES { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Description RCS")]
        public string Description_RCS { get; set; }
        [Required]
        [DisplayName("Value RCS")]
        public float Value_RCS { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Description RES")]
        public string Description_RES { get; set; }
        [Required]
        [DisplayName("Value RES")]
        public float Value_RES { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Description VBS")]
        public string Description_VBS { get; set; }
        [Required]
        [DisplayName("Value VBS")]
        public float Value_VBS { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Description AF")]
        public string Description_AF { get; set; }
        [Required]
        [DisplayName("Value AF")]
        public float Value_AF { get; set; }

        [Required]
        [DisplayName("Amount of Animals")]
        public int AnimalsAmount { get; set; }

        [DefaultValue(0)]
        [DisplayName("IVEA")]
        public float IVEA { get; set; }
    }
}
