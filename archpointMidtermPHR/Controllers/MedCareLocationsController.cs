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
    public class MedCareLocationsController : Controller
    {
        private readonly ArchpointContext _context;

        public MedCareLocationsController(ArchpointContext context)
        {
            _context = context;
        }

        // GET: MedCareLocations
        public async Task<IActionResult> Index()
        {
            return View(await _context.MedCareLocation.ToListAsync());
        }

        // GET: MedCareLocations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medCareLocation = await _context.MedCareLocation
                .FirstOrDefaultAsync(m => m.LocationId == id);
            if (medCareLocation == null)
            {
                return NotFound();
            }

            return View(medCareLocation);
        }

        // GET: MedCareLocations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MedCareLocations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LocationId,LocationStreetAddress,LocationCity,LocationStateProvince,LocationZipCode,LocationCountry,LocationPhoneNum,LocationFax,LocationEmail,LocationName")] MedCareLocation medCareLocation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medCareLocation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(medCareLocation);
        }

        // GET: MedCareLocations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medCareLocation = await _context.MedCareLocation.FindAsync(id);
            if (medCareLocation == null)
            {
                return NotFound();
            }
            return View(medCareLocation);
        }

        // POST: MedCareLocations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LocationId,LocationStreetAddress,LocationCity,LocationStateProvince,LocationZipCode,LocationCountry,LocationPhoneNum,LocationFax,LocationEmail,LocationName")] MedCareLocation medCareLocation)
        {
            if (id != medCareLocation.LocationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medCareLocation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedCareLocationExists(medCareLocation.LocationId))
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
            return View(medCareLocation);
        }

        // GET: MedCareLocations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medCareLocation = await _context.MedCareLocation
                .FirstOrDefaultAsync(m => m.LocationId == id);
            if (medCareLocation == null)
            {
                return NotFound();
            }

            return View(medCareLocation);
        }

        // POST: MedCareLocations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var medCareLocation = await _context.MedCareLocation.FindAsync(id);
            _context.MedCareLocation.Remove(medCareLocation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedCareLocationExists(int id)
        {
            return _context.MedCareLocation.Any(e => e.LocationId == id);
        }
    }
}
