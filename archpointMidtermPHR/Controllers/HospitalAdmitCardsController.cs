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
    public class HospitalAdmitCardsController : Controller
    {
        private readonly ArchpointContext _context;

        public HospitalAdmitCardsController(ArchpointContext context)
        {
            _context = context;
        }

        // GET: HospitalAdmitCards
        public async Task<IActionResult> Index()
        {
            return View(await _context.HospitalAdmitCard.ToListAsync());
        }

        // GET: HospitalAdmitCards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hospitalAdmitCard = await _context.HospitalAdmitCard
                .FirstOrDefaultAsync(m => m.HospitalAdmitId == id);
            if (hospitalAdmitCard == null)
            {
                return NotFound();
            }

            return View(hospitalAdmitCard);
        }

        // GET: HospitalAdmitCards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HospitalAdmitCards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HospitalAdmitId,PatientId,EmployerId,EmergencyContactId,InsuranceId,PolicyHolderId")] HospitalAdmitCard hospitalAdmitCard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hospitalAdmitCard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hospitalAdmitCard);
        }

        // GET: HospitalAdmitCards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hospitalAdmitCard = await _context.HospitalAdmitCard.FindAsync(id);
            if (hospitalAdmitCard == null)
            {
                return NotFound();
            }
            return View(hospitalAdmitCard);
        }

        // POST: HospitalAdmitCards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HospitalAdmitId,PatientId,EmployerId,EmergencyContactId,InsuranceId,PolicyHolderId")] HospitalAdmitCard hospitalAdmitCard)
        {
            if (id != hospitalAdmitCard.HospitalAdmitId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hospitalAdmitCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HospitalAdmitCardExists(hospitalAdmitCard.HospitalAdmitId))
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
            return View(hospitalAdmitCard);
        }

        // GET: HospitalAdmitCards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hospitalAdmitCard = await _context.HospitalAdmitCard
                .FirstOrDefaultAsync(m => m.HospitalAdmitId == id);
            if (hospitalAdmitCard == null)
            {
                return NotFound();
            }

            return View(hospitalAdmitCard);
        }

        // POST: HospitalAdmitCards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hospitalAdmitCard = await _context.HospitalAdmitCard.FindAsync(id);
            _context.HospitalAdmitCard.Remove(hospitalAdmitCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HospitalAdmitCardExists(int id)
        {
            return _context.HospitalAdmitCard.Any(e => e.HospitalAdmitId == id);
        }
    }
}
