using IVEACore.Data;
using IVEACore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace IVEACore.Controllers
{
    [Authorize]
    public class IndicatorsController : Controller
    {
        private readonly IVEACoreContext _context;

        public IndicatorsController(IVEACoreContext context)
        {
            _context = context;
        }

        // GET: Indicators
        public async Task<IActionResult> Index()
        {
            return View(await _context.Indicator.ToListAsync());
        }

        // GET: Indicators/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indicator = await _context.Indicator
                .FirstOrDefaultAsync(m => m.Id_Indicator == id);
            if (indicator == null)
            {
                return NotFound();
            }

            return View(indicator);
        }

        // GET: Indicators/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Indicators/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Indicator,NameIndicator,CodeIndicator")] Indicator indicator)
        {
            if (ModelState.IsValid)
            {
                _context.Add(indicator);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(indicator);
        }

        // GET: Indicators/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indicator = await _context.Indicator.FindAsync(id);
            if (indicator == null)
            {
                return NotFound();
            }
            return View(indicator);
        }

        // POST: Indicators/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Indicator,NameIndicator,CodeIndicator")] Indicator indicator)
        {
            if (id != indicator.Id_Indicator)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(indicator);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IndicatorExists(indicator.Id_Indicator))
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
            return View(indicator);
        }

        // GET: Indicators/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indicator = await _context.Indicator
                .FirstOrDefaultAsync(m => m.Id_Indicator == id);
            if (indicator == null)
            {
                return NotFound();
            }

            return View(indicator);
        }

        // POST: Indicators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var indicator = await _context.Indicator.FindAsync(id);
            _context.Indicator.Remove(indicator);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IndicatorExists(int id)
        {
            return _context.Indicator.Any(e => e.Id_Indicator == id);
        }

        //Printing the view to PDF.
        public ActionResult PrintIndicatorPDF()
        {   
            var indicator = _context.Indicator.ToList();
            return new ViewAsPdf(indicator)
            {
                CustomSwitches = "--footer-center \"  Created Date: " +
                                DateTime.Now.Date.ToString("dd/MM/yyyy") + "  Page: [page]/[toPage]\"" +
                                " --footer-line --footer-font-size \"8\" --footer-spacing 1 --footer-font-name \"Segoe UI\""
            };
        }
    }
}
