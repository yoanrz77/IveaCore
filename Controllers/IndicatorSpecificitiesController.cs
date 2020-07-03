using IVEACore.Data;
using IVEACore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;
using System.Linq;
using System.Threading.Tasks;

namespace IVEACore.Controllers
{
    [Authorize]
    public class IndicatorSpecificitiesController : Controller
    {
        private readonly IVEACoreContext _context;

        public IndicatorSpecificitiesController(IVEACoreContext context)
        {
            _context = context;
        }

        // GET: IndicatorSpecificities
        public async Task<IActionResult> Index()
        {
            return View(await _context.IndicatorSpecificity.ToListAsync());
        }

        // GET: IndicatorSpecificities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indicatorSpecificity = await _context.IndicatorSpecificity
                .FirstOrDefaultAsync(m => m.Id_IndicatorSpecificity == id);
            if (indicatorSpecificity == null)
            {
                return NotFound();
            }

            return View(indicatorSpecificity);
        }

        //Defining values to use in the dropdownlists
        private void SetIndicadorSpecifitiesViewBag(int? Id_Indicator = null)
        {
            if (Id_Indicator == null)
            {
                ViewBag.Id_Indicator = new SelectList(_context.Indicator, "Id_Indicator", "NameIndicator");
            }
            else
            {
                ViewBag.Id_Indicator = new SelectList(_context.Indicator.ToArray(), "Id_Indicator", "NameIndicator", Id_Indicator);
            }
        }

        // GET: IndicatorSpecificities/Create
        public IActionResult Create()
        {
            SetIndicadorSpecifitiesViewBag();
            return View();
        }

        // POST: IndicatorSpecificities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_IndicatorSpecificity,Id_Indicator,Specificity")] IndicatorSpecificity indicatorSpecificity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(indicatorSpecificity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(indicatorSpecificity);
        }

        // GET: IndicatorSpecificities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indicatorSpecificity = await _context.IndicatorSpecificity.FindAsync(id);
            if (indicatorSpecificity == null)
            {
                return NotFound();
            }
            return View(indicatorSpecificity);
        }

        // POST: IndicatorSpecificities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_IndicatorSpecificity,Id_Indicator,Specificity")] IndicatorSpecificity indicatorSpecificity)
        {
            if (id != indicatorSpecificity.Id_IndicatorSpecificity)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(indicatorSpecificity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IndicatorSpecificityExists(indicatorSpecificity.Id_IndicatorSpecificity))
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
            return View(indicatorSpecificity);
        }

        // GET: IndicatorSpecificities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indicatorSpecificity = await _context.IndicatorSpecificity
                .FirstOrDefaultAsync(m => m.Id_IndicatorSpecificity == id);
            if (indicatorSpecificity == null)
            {
                return NotFound();
            }

            return View(indicatorSpecificity);
        }

        // POST: IndicatorSpecificities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var indicatorSpecificity = await _context.IndicatorSpecificity.FindAsync(id);
            _context.IndicatorSpecificity.Remove(indicatorSpecificity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IndicatorSpecificityExists(int id)
        {
            return _context.IndicatorSpecificity.Any(e => e.Id_IndicatorSpecificity == id);
        }

        //Printing the view to PDF.
        public ActionResult PrintIndicatorSpecificitiesPDF()
        {
            var indicatorSpecificities = _context.IndicatorSpecificity.ToList();
            return new ViewAsPdf(indicatorSpecificities);
        }

    }
}
