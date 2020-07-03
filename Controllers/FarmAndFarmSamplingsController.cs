using IVEACore.Data;
using IVEACore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace IVEACore.Controllers
{
    [Authorize]
    public class FarmAndFarmSamplingsController : Controller
    {
        private readonly IVEACoreContext _context;

        public FarmAndFarmSamplingsController(IVEACoreContext context)
        {
            _context = context;
        }

        public ActionResult Ivea()
        {
            var result = new List<FarmAndFarmSamplingsViewModel>();

            List<Farm> FarmList = _context.Farm.ToList();
            List<FarmSampling> FarmSamplingList = _context.FarmSampling.ToList();

            foreach (var f in FarmList)
            {
                var fs = FarmSamplingList.Where(e => e.Id_Farm == f.Id_Farm).ToList();
                foreach (var item in fs)
                {
                    var vm = new FarmAndFarmSamplingsViewModel
                    {
                        FarmName = f.NameFarm,
                        DateSampling = item.DateSampling,
                        FirstNameFarmer = f.FirstNameFarmer,
                        LastNameFarmer = f.LastNameFarmer,
                        Ivea = item.IVEA,
                    };
                    result.Add(vm);
                }
            }
            return View(result);
        }

        public ActionResult PrintIveaPDF()
        {
            var result = new List<FarmAndFarmSamplingsViewModel>();

            List<Farm> FarmList = _context.Farm.ToList();
            List<FarmSampling> FarmSamplingList = _context.FarmSampling.ToList();

            foreach (var f in FarmList)
            {
                var fs = FarmSamplingList.Where(e => e.Id_Farm == f.Id_Farm).ToList();
                foreach (var item in fs)
                {
                    var vm = new FarmAndFarmSamplingsViewModel
                    {
                        FarmName = f.NameFarm,
                        DateSampling = item.DateSampling,
                        FirstNameFarmer = f.FirstNameFarmer,
                        LastNameFarmer = f.LastNameFarmer,
                        Ivea = item.IVEA,
                    };
                    result.Add(vm);
                }
            }
            return new ViewAsPdf(result);
        }
    }
}
