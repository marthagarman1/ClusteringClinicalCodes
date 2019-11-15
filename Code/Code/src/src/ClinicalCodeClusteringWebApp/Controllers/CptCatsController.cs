using System.Linq;
using System.Threading.Tasks;
using ClinicalCodeClusteringWebApp.Data;
using ClinicalCodeClusteringWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ClinicalCodeClusteringWebApp.Controllers
{
    /// <summary>
    /// Handles requests for CPTCategory requests.
    /// Updates database. 
    /// </summary>
    public class CptCatsController : Controller
    {
        public static IConfigurationRoot Configuration;

        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        // GET: CptCats
        public async Task<IActionResult> Index()
        {
            return View(await _context.CptCats.ToListAsync());
        }

        // GET: CptCats/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null) return NotFound();

            var cptCats = await _context.CptCats
                .FirstOrDefaultAsync(m => m.ClaimId == id);
            if (cptCats == null) return NotFound();

            return View(cptCats);
        }

        // GET: CptCats/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CptCats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("ClaimId,DrugAssay,Microbiology,Chemistry,DiseasePanels,Hematology,Urinalysis,Immunology,Cat8,Cat9")]
            CPTCats cptCats)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cptCats);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(cptCats);
        }

        // GET: CptCats/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null) return NotFound();

            var cptCats = await _context.CptCats.FindAsync(id);
            if (cptCats == null) return NotFound();
            return View(cptCats);
        }

        // POST: CptCats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id,
            [Bind("ClaimId,DrugAssay,Microbiology,Chemistry,DiseasePanels,Hematology,Urinalysis,Immunology,Cat8,Cat9")]
            CPTCats cptCats)
        {
            if (id != cptCats.ClaimId) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cptCats);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CptCatsExists(cptCats.ClaimId))
                        return NotFound();
                    throw;
                }

                return RedirectToAction(nameof(Index));
            }

            return View(cptCats);
        }

        // GET: CptCats/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null) return NotFound();

            var cptCats = await _context.CptCats
                .FirstOrDefaultAsync(m => m.ClaimId == id);
            if (cptCats == null) return NotFound();

            return View(cptCats);
        }

        // POST: CptCats/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var cptCats = await _context.CptCats.FindAsync(id);
            _context.CptCats.Remove(cptCats);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CptCatsExists(string id)
        {
            return _context.CptCats.Any(e => e.ClaimId == id);
        }
    }
}