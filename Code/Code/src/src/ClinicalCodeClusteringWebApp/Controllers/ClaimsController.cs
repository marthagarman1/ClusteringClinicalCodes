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
    /// Handles all requests for claim data. 
    /// </summary>
    public class ClaimsController : Controller
    {
        public static IConfigurationRoot Configuration;

        private readonly ApplicationDbContext _context = new ApplicationDbContext();


        // GET: Claims
        public async Task<IActionResult> Index()
        {
            return View(await _context.Claims.ToListAsync());
        }

        // GET: Claims/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null) return NotFound();

            var claims = _context.Claims.Find(CompositeKey(id));

            if (claims == null) return NotFound();

            return View(claims);
        }

        // GET: Claims/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Claims/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClaimId,Cpt,ChargeAmount,PaymentAmount,DateOfSubmission")]
            Claims claims)
        {
            if (ModelState.IsValid)
            {
                _context.Add(claims);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(claims);
        }

        // GET: Claims/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null) return NotFound();

            var claims = _context.Claims.Find(CompositeKey(id));
            if (claims == null) return NotFound();
            return View(claims);
        }

        // POST: Claims/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id,
            [Bind("ClaimId,Cpt,ChargeAmount,PaymentAmount,DateOfSubmission")]
            Claims claims)
        {
            var existing = await _context.Claims.FindAsync(CompositeKey(id));

            if (existing == null) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Claims.Update(claims);
                    //_context.Update(claims);
                    await _context.SaveChangesAsync();
                    _context.Entry(claims).State = EntityState.Detached;
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClaimsExists(claims.ClaimId))
                        return NotFound();
                    throw;
                }

                return RedirectToAction(nameof(Index));
            }

            return View(claims);
        }

        // GET: Claims/Delete/5

        public async Task<IActionResult> Delete(string id)
        {
            if (id == null) return NotFound();

            var claims = _context.Claims.Find(CompositeKey(id));

            /*var claims = await _context.Claims
                            .FirstOrDefaultAsync(m => m.ClaimId == id);*/
            if (claims == null) return NotFound();

            return View(claims);
        }

        // POST: Claims/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var claims = await _context.Claims.FindAsync(CompositeKey(id));
            _context.Claims.Remove(claims);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClaimsExists(string id)
        {
            return _context.Claims.Any(e => e.ClaimId == id);
        }

        private object[] CompositeKey(string id)
        {
            string[] compositeKey;
            return compositeKey = id.Split('-');
        }
    }
}