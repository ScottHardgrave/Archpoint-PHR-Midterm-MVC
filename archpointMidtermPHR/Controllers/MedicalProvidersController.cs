using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using archpointMidtermPHR.Models;

namespace archpointMidtermPHR.Controllers
{
    public class MedicalProvidersController : Controller
    {
        private readonly ArchpointContext _context;

        public MedicalProvidersController(ArchpointContext context)
        {
            _context = context;
        }

        // GET: MedicalProviders
        public async Task<IActionResult> Index()
        {
            var archpointContext = _context.MedicalProvider.Include(m => m.MedProviderLocation);
            return View(await archpointContext.ToListAsync());
        }

        // GET: MedicalProviders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicalProvider = await _context.MedicalProvider
                .Include(m => m.MedProviderLocation)
                .FirstOrDefaultAsync(m => m.MedProviderId == id);
            if (medicalProvider == null)
            {
                return NotFound();
            }

            return View(medicalProvider);
        }

        // GET: MedicalProviders/Create
        public IActionResult Create()
        {
            ViewData["MedProviderLocationId"] = new SelectList(_context.MedCareLocation, "LocationId", "LocationCity");
            return View();
        }

        // POST: MedicalProviders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MedProviderId,MedProviderSpecialty,ActiveOrInactive,MedProviderFirstName,MedProviderLastName,MedProviderLocationId,PhoneNumber,Fax,Email")] MedicalProvider medicalProvider)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medicalProvider);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MedProviderLocationId"] = new SelectList(_context.MedCareLocation, "LocationId", "LocationCity", medicalProvider.MedProviderLocationId);
            return View(medicalProvider);
        }

        // GET: MedicalProviders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicalProvider = await _context.MedicalProvider.FindAsync(id);
            if (medicalProvider == null)
            {
                return NotFound();
            }
            ViewData["MedProviderLocationId"] = new SelectList(_context.MedCareLocation, "LocationId", "LocationCity", medicalProvider.MedProviderLocationId);
            return View(medicalProvider);
        }

        // POST: MedicalProviders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MedProviderId,MedProviderSpecialty,ActiveOrInactive,MedProviderFirstName,MedProviderLastName,MedProviderLocationId,PhoneNumber,Fax,Email")] MedicalProvider medicalProvider)
        {
            if (id != medicalProvider.MedProviderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medicalProvider);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicalProviderExists(medicalProvider.MedProviderId))
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
            ViewData["MedProviderLocationId"] = new SelectList(_context.MedCareLocation, "LocationId", "LocationCity", medicalProvider.MedProviderLocationId);
            return View(medicalProvider);
        }

        // GET: MedicalProviders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicalProvider = await _context.MedicalProvider
                .Include(m => m.MedProviderLocation)
                .FirstOrDefaultAsync(m => m.MedProviderId == id);
            if (medicalProvider == null)
            {
                return NotFound();
            }

            return View(medicalProvider);
        }

        // POST: MedicalProviders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var medicalProvider = await _context.MedicalProvider.FindAsync(id);
            _context.MedicalProvider.Remove(medicalProvider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicalProviderExists(int id)
        {
            return _context.MedicalProvider.Any(e => e.MedProviderId == id);
        }
    }
}
