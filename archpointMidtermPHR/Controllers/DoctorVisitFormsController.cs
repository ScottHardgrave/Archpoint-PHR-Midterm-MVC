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
    public class DoctorVisitFormsController : Controller
    {
        private readonly ArchpointContext _context;

        public DoctorVisitFormsController(ArchpointContext context)
        {
            _context = context;
        }

        // GET: DoctorVisitForms
        public async Task<IActionResult> Index()
        {
            return View(await _context.DoctorVisitForm.ToListAsync());
        }

        // GET: DoctorVisitForms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctorVisitForm = await _context.DoctorVisitForm
                .FirstOrDefaultAsync(m => m.ReasonForVisitId == id);
            if (doctorVisitForm == null)
            {
                return NotFound();
            }

            return View(doctorVisitForm);
        }

        // GET: DoctorVisitForms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DoctorVisitForms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReasonForVisitId,CurrentComplaint,CurrentMedQuestion")] DoctorVisitForm doctorVisitForm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doctorVisitForm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(doctorVisitForm);
        }

        // GET: DoctorVisitForms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctorVisitForm = await _context.DoctorVisitForm.FindAsync(id);
            if (doctorVisitForm == null)
            {
                return NotFound();
            }
            return View(doctorVisitForm);
        }

        // POST: DoctorVisitForms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReasonForVisitId,CurrentComplaint,CurrentMedQuestion")] DoctorVisitForm doctorVisitForm)
        {
            if (id != doctorVisitForm.ReasonForVisitId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doctorVisitForm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoctorVisitFormExists(doctorVisitForm.ReasonForVisitId))
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
            return View(doctorVisitForm);
        }

        // GET: DoctorVisitForms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctorVisitForm = await _context.DoctorVisitForm
                .FirstOrDefaultAsync(m => m.ReasonForVisitId == id);
            if (doctorVisitForm == null)
            {
                return NotFound();
            }

            return View(doctorVisitForm);
        }

        // POST: DoctorVisitForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doctorVisitForm = await _context.DoctorVisitForm.FindAsync(id);
            _context.DoctorVisitForm.Remove(doctorVisitForm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoctorVisitFormExists(int id)
        {
            return _context.DoctorVisitForm.Any(e => e.ReasonForVisitId == id);
        }
    }
}
