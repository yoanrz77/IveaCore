using IVEACore.Data;
using IVEACore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IVEACore.Controllers
{
    [Authorize]
    public class ServiceListController : Controller
    {
        private readonly IVEACoreContext _context;

        public ServiceListController(IVEACoreContext context)
        {
            _context = context;
        }

        // GET: GetListElements
        [HttpGet, ActionName("ListElments")]
        public JsonResult GetListElements()
        {
            var result = new Dictionary<string, List<ListsElements>>();

            var lists = _context.IndicatorSpecificity.Include(e=> e.Indicator).ToList();
            var farms = _context.Farm.ToList();

            result.Add("Farm", ToFarmElements(farms));

            result.Add("CFV", ToListElements(lists,"CFV"));
            result.Add("DAS", ToListElements(lists,"DAS"));
            result.Add("DFS", ToListElements(lists,"DFS"));
            result.Add("MPE", ToListElements(lists,"MPE"));
            result.Add("NCS", ToListElements(lists,"NCS"));
            result.Add("NES", ToListElements(lists,"NES"));
            result.Add("NRS", ToListElements(lists,"NRS"));
            result.Add("PES", ToListElements(lists,"PES"));
            result.Add("RCES", ToListElements(lists,"RCES"));
            result.Add("RCS", ToListElements(lists,"RCS"));
            result.Add("RES", ToListElements(lists,"RES"));
            result.Add("VBS", ToListElements(lists,"VBS"));
            result.Add("AF", ToListElements(lists,"AF"));

            return Json(result);
        }

        private List<ListsElements> ToFarmElements(List<Farm> farms)
        {
            var result = new List<ListsElements>();

            foreach (var item in farms)
            {
                result.Add(new ListsElements()
                {
                    Id = item.Id_Farm.ToString(),
                    Description = item.NameFarm
                });
            }

            return result;
        }

        private List<ListsElements> ToListElements(List<IndicatorSpecificity> IndSpecif, string code)
        {

            var result = new List<ListsElements>();

            foreach (var item in IndSpecif.Where(e=>e.Indicator.CodeIndicator==code))
            {
                result.Add(new ListsElements()
                {
                    Id = item.Id_IndicatorSpecificity.ToString(),
                    LinkId= item.Indicator.CodeIndicator,
                    Description = item.Specificity
                });
            }

            return result;
        }
    }
}
