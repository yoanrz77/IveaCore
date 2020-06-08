using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IVEACore.Models
{
    public class Farm
    {
        [Key]
        public int Id_Farm { get; set; }

        [Required]
        [StringLength(255)]
        public string NameFarm { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstNameFarmer { get; set; }

        [Required]
        [StringLength(255)]
        public string LastNameFarmer { get; set; }

        [Required]
        [StringLength(255)]
        public string AddressFarm { get; set; }

        [Required]
        public double FarmExtention { get; set; }
    }
}
