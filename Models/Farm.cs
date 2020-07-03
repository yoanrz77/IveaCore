using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IVEACore.Models
{
    public class Farm
    {
        [Key]
        [DisplayName("Id")]
        public int Id_Farm { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Farm Name")]
        public string NameFarm { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Farmer First Name")]
        public string FirstNameFarmer { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Farmer Last Name")]
        public string LastNameFarmer { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Address")]
        public string AddressFarm { get; set; }

        [Required]
        [DisplayName("Farm Extention")]
        public double FarmExtention { get; set; }
    }
}
