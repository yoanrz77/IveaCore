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

        // GET: /Home/
        //public ActionResult Ivea()
        //{
        //    FarmAndFarmSamplingViewModel vm = new FarmAndFarmSamplingViewModel();
        //    vm.Farm = GetQueryFarm();
        //    //vm.FarmSamplings = GetQueryFarmSampling();

        //    return View(vm); //pass it into the page
        //}

        //string GetQueryFarm()
        //{
        //    DataTable data = GetDataFromQuery("SELECT * FROM Farm");
        //    string myData = data.ToString();
        //    return myData;
        //}

        ////string[] GetQueryFarmSampling()
        ////{
        ////    DataTable data = GetDataFromQuery("SELECT * FROM FarmSampling");

        ////    //DataTable data = GetDataFromQuery("SELECT Farm.Id_Farm, FarmSampling.Id_FamSampling, FarmSampling.DateSampling, farm.FirstNameFarmer, " +
        ////    //"Farm.LastNameFarmer, Farm.NameFarm, Farm.FarmExtention, FarmSampling.IVEA FROM FarmSampling " +
        ////    //"LEFT JOIN Farm ON FarmSampling.Id_Farm = Farm.Id_Farm ORDER BY Farm.Id_Farm");
        ////    ////convert the data into a string[] and return it

        ////    return data;
        ////}

        //DataTable GetDataFromQuery(string query)
        //{
        //    //var MyConntection = _context.Database.GetDbConnection();
        //    string MyConntection = "Server=(localdb)\\mssqllocaldb;Database=aspnet-IVEACore-EF8713C6-08D9-4DE7-B368-9E8C9A515468;Trusted_Connection=True;MultipleActiveResultSets=true";
        //    SqlDataAdapter adap = new SqlDataAdapter(query, MyConntection);
        //    DataTable data = new DataTable();
        //    adap.Fill(data);
        //    return data;
        //}
    }
}
