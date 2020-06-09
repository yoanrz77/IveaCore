using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IVEACore.Data;
using IVEACore.Models;

namespace IVEACore.Controllers
{
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

        // GET: FarmSamplings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FarmSamplings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_FamSampling,Id_Farm,DateSampling,Details,Description_CFV,Value_CFV,Description_DAS,Value_DAS,Description_DFS,Value_DFS,Description_MPE,Value_MPE,Description_NCS,Value_NCS,Description_NES,Value_NES,Description_NRS,Value_NRS,Description_PES,Value_PES,Description_RCES,Value_RCES,Description_RCS,Value_RCS,Description_RES,Value_RES,Description_VBS,Value_VBS,Description_AF,Value_AF,AnimalsAmount")] FarmSampling farmSampling)
        {
            if (ModelState.IsValid)
            {
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
        public async Task<IActionResult> Edit(int id, [Bind("Id_FamSampling,Id_Farm,DateSampling,Details,Description_CFV,Value_CFV,Description_DAS,Value_DAS,Description_DFS,Value_DFS,Description_MPE,Value_MPE,Description_NCS,Value_NCS,Description_NES,Value_NES,Description_NRS,Value_NRS,Description_PES,Value_PES,Description_RCES,Value_RCES,Description_RCS,Value_RCS,Description_RES,Value_RES,Description_VBS,Value_VBS,Description_AF,Value_AF,AnimalsAmount")] FarmSampling farmSampling)
        {
            if (id != farmSampling.Id_FamSampling)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
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
    }
}
