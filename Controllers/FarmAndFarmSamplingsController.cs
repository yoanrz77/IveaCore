using IVEACore.Data;
using IVEACore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;
using System;
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
            return new ViewAsPdf(result)
            {
                CustomSwitches = "--footer-center \"  Created Date: " +
                                DateTime.Now.Date.ToString("dd/MM/yyyy") + "  Page: [page]/[toPage]\"" +
                                " --footer-line --footer-font-size \"8\" --footer-spacing 1 --footer-font-name \"Segoe UI\""
            };
        }
    }
}
