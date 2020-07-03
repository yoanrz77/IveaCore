using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IVEACore.Models
{
    public class FarmAndFarmSamplingsViewModel
    {
        //public List<Farm> allFarms { get; set; }
        //public List<FarmSampling> allFarmSamplings { get; set; }

        public int Id_Farm { get; set; }
        public int Id_FarmSampling { get; set; }
        public string FarmName { get; set; }
        public DateTime DateSampling { get; set; }
        public string FirstNameFarmer { get; set; }
        public string LastNameFarmer { get; set; }
        public float Ivea { get; set; }
    }
}
