using System;

namespace IVEACore.Models
{
    public class FarmAndFarmSamplingsViewModel
    {
        public int Id_Farm { get; set; }
        public int Id_FarmSampling { get; set; }
        public string FarmName { get; set; }
        public DateTime DateSampling { get; set; }
        public string FirstNameFarmer { get; set; }
        public string LastNameFarmer { get; set; }
        public float Ivea { get; set; }
    }
}
