﻿using IVEACore.Data;
using IVEACore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace IVEACore.Controllers
{
    [Authorize]
    public class FarmSamplingsController : Controller
    {
        private readonly IVEACoreContext _context;

        public FarmSamplingsController(IVEACoreContext context)
        {
            _context = context;
        }

        // GET: FarmSamplings
        public async Task<IActionResult> Index()
        {
            return View(await _context.FarmSampling.ToListAsync());
        }

        // GET: FarmSamplings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var farmSampling = await _context.FarmSampling
                .FirstOrDefaultAsync(m => m.Id_FamSampling == id);
            if (farmSampling == null)
            {
                return NotFound();
            }

            return View(farmSampling);
        }

        //Defining values to use in the dropdownlists
        private void SetFarmSamplingsViewBag(int? Id_Farm = null)
        {
            if (Id_Farm == null)
            {
                ViewBag.Id_Farm = new SelectList(_context.Farm, "Id_Farm", "NameFarm");

                //List of values for each indicator 
                var ValueList = new List<int>() { 1,2,3,4,5,6,7,8,9};
                
                //Filtering the values  
                var ValueListFiltered = ValueList.Where(v => v <= 3);

                ViewBag.CFV_Value = new SelectList(ValueListFiltered);
            }
            else
            {
                ViewBag.Id_Farm = new SelectList(_context.Farm.ToArray(), "Id_Farm", "NameFarm", Id_Farm);
            }
        }

        // GET: FarmSamplings/Create
        public IActionResult Create()
        {
            //FarmSampling fs = new FarmSampling();
            //int af = Convert.ToInt32(fs.Description_AF);
            //int cfv =Convert.ToInt32(fs.Description_CFV);
            //IveaIndex iveaIndex = new IveaIndex();
            //ViewBag.IVEA = iveaIndex.CalculateIvea(af,cfv);

            SetFarmSamplingsViewBag();
            return View();
        }

        // POST: FarmSamplings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_FamSampling,Id_Farm,DateSampling,Details,Description_CFV,Value_CFV,Description_DAS," +
            "Value_DAS,Description_DFS,Value_DFS,Description_MPE,Value_MPE,Description_NCS,Value_NCS,Description_NES,Value_NES,Description_NRS," +
            "Value_NRS,Description_PES,Value_PES,Description_RCES,Value_RCES,Description_RCS,Value_RCS,Description_RES,Value_RES,Description_VBS," +
            "Value_VBS,Description_AF,Value_AF,AnimalsAmount,IVEA")] FarmSampling farmSampling)
        {
            ////***Here
            //IveaIndex iveaIndex = new IveaIndex(_context);
            //var IndexVal = iveaIndex.CalculateIvea(farmSampling.Id_FamSampling);

            //***Here
            //FarmSampling fs = new FarmSampling();
            //fs.IVEA = IndexVal;

            if (ModelState.IsValid)
            {
                IveaIndex iveaIndex = new IveaIndex();
                var IndexVal = iveaIndex.CalculateIvea(farmSampling.Value_CFV, farmSampling.Value_DAS, farmSampling.Value_DFS,
                                farmSampling.Value_MPE, farmSampling.Value_NCS, farmSampling.Value_NES, farmSampling.Value_NRS,
                                farmSampling.Value_PES, farmSampling.Value_RCES, farmSampling.Value_RCS, farmSampling.Value_RES,
                                farmSampling.Value_VBS, farmSampling.Value_AF);
                
                farmSampling.IVEA = IndexVal;

                _context.Add(farmSampling);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(farmSampling);
        }

        // GET: FarmSamplings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var farmSampling = await _context.FarmSampling.FindAsync(id);
            if (farmSampling == null)
            {
                return NotFound();
            }

            return View(farmSampling);
        }

        // POST: FarmSamplings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_FamSampling,Id_Farm,DateSampling,Details,Description_CFV,Value_CFV,Description_DAS," +
            "Value_DAS,Description_DFS,Value_DFS,Description_MPE,Value_MPE,Description_NCS,Value_NCS,Description_NES,Value_NES,Description_NRS," +
            "Value_NRS,Description_PES,Value_PES,Description_RCES,Value_RCES,Description_RCS,Value_RCS,Description_RES,Value_RES,Description_VBS," +
            "Value_VBS,Description_AF,Value_AF,AnimalsAmount,IVEA")] FarmSampling farmSampling)
        {
            if (id != farmSampling.Id_FamSampling)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    IveaIndex iveaIndex = new IveaIndex();
                    var IndexVal = iveaIndex.CalculateIvea(farmSampling.Value_CFV, farmSampling.Value_DAS, farmSampling.Value_DFS,
                                    farmSampling.Value_MPE, farmSampling.Value_NCS, farmSampling.Value_NES, farmSampling.Value_NRS,
                                    farmSampling.Value_PES, farmSampling.Value_RCES, farmSampling.Value_RCS, farmSampling.Value_RES,
                                    farmSampling.Value_VBS, farmSampling.Value_AF);

                    farmSampling.IVEA = IndexVal;

                    _context.Update(farmSampling);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FarmSamplingExists(farmSampling.Id_FamSampling))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(farmSampling);
        }

        // GET: FarmSamplings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var farmSampling = await _context.FarmSampling
                .FirstOrDefaultAsync(m => m.Id_FamSampling == id);
            if (farmSampling == null)
            {
                return NotFound();
            }

            return View(farmSampling);
        }

        // POST: FarmSamplings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var farmSampling = await _context.FarmSampling.FindAsync(id);
            _context.FarmSampling.Remove(farmSampling);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FarmSamplingExists(int id)
        {
            return _context.FarmSampling.Any(e => e.Id_FamSampling == id);
        }

        //Printing the view to PDF.
        public ActionResult FarmSamplingsPDF()
        {
            var farmSampling = _context.FarmSampling.ToList();
            return new Rotativa.AspNetCore.ViewAsPdf(farmSampling);
            //{
            //    PageSize = Rotativa.AspNetCore.Options.Size.A3,  
            //};
            //  {
            //      CustomSwitches =
            //  "--footer-center \"  Created Date: " +
            //DateTime.Now.Date.ToString("dd/MM/yyyy") + "  Page: [page]/[toPage]\"" +
            //" --footer-line --footer-font-size \"12\" --footer-spacing 1 --footer-font-name \"Segoe UI\""
            //  };
        }

        //// GET: FarmSamplings/Edit/5
        //public async Task<IActionResult> CalcIveaIndex(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var farmSampling = await _context.FarmSampling.FindAsync(id);

        //    //***Here
        //    IveaIndex iveaIndex = new IveaIndex(_context);
        //    var IndexVal = iveaIndex.CalculateIvea(farmSampling.Id_FamSampling);

        //    farmSampling.IVEA = IndexVal;
        //    if (farmSampling == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(farmSampling);
        //}



    }
}
