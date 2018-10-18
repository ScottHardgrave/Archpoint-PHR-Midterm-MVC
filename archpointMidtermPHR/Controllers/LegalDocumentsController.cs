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
    public class LegalDocumentsController : Controller
    {
        private readonly ArchpointContext _context;

        public LegalDocumentsController(ArchpointContext context)
        {
            _context = context;
        }

        // GET: LegalDocuments
        public async Task<IActionResult> Index()
        {
            return View(await _context.LegalDocuments.ToListAsync());
        }

        // GET: LegalDocuments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var legalDocuments = await _context.LegalDocuments
                .FirstOrDefaultAsync(m => m.LegalDocId == id);
            if (legalDocuments == null)
            {
                return NotFound();
            }

            return View(legalDocuments);
        }

        // GET: LegalDocuments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LegalDocuments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LegalDocId,LivingWill,LivingWillDateSigned,LivingWillLastUpdated,LivingWillCopyOnFile,FamilyAwareOfInstructions,MedicalPowerOfAttorney,MedPowerOfAttorneyName,MedPowerOfAttorneyDateSigned,MedPowerOfAttorneyDateLastUpdated,MedPowerOfAttorneyCopyOnFile,HealthCareProxy,HealthCareProxyName,HealthCareProxyDateSigned,HealtchCareProxyDateLastUpdated,DoNotResuscitateOrder,DnrDateSigned,DnrDateLastUpdated,OrganDonorDocument,OrganDonorDateSigned,OrganDonorLastUpdate,DocumentsLocation,DocumentContactsFirstName,DocumentContactsLastName,DocumentContactsPhone,AttorneyFirstName,AttorneyLastName,AttorneyPhone,Comments")] LegalDocuments legalDocuments)
        {
            if (ModelState.IsValid)
            {
                _context.Add(legalDocuments);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(legalDocuments);
        }

        // GET: LegalDocuments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var legalDocuments = await _context.LegalDocuments.FindAsync(id);
            if (legalDocuments == null)
            {
                return NotFound();
            }
            return View(legalDocuments);
        }

        // POST: LegalDocuments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LegalDocId,LivingWill,LivingWillDateSigned,LivingWillLastUpdated,LivingWillCopyOnFile,FamilyAwareOfInstructions,MedicalPowerOfAttorney,MedPowerOfAttorneyName,MedPowerOfAttorneyDateSigned,MedPowerOfAttorneyDateLastUpdated,MedPowerOfAttorneyCopyOnFile,HealthCareProxy,HealthCareProxyName,HealthCareProxyDateSigned,HealtchCareProxyDateLastUpdated,DoNotResuscitateOrder,DnrDateSigned,DnrDateLastUpdated,OrganDonorDocument,OrganDonorDateSigned,OrganDonorLastUpdate,DocumentsLocation,DocumentContactsFirstName,DocumentContactsLastName,DocumentContactsPhone,AttorneyFirstName,AttorneyLastName,AttorneyPhone,Comments")] LegalDocuments legalDocuments)
        {
            if (id != legalDocuments.LegalDocId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(legalDocuments);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LegalDocumentsExists(legalDocuments.LegalDocId))
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
            return View(legalDocuments);
        }

        // GET: LegalDocuments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var legalDocuments = await _context.LegalDocuments
                .FirstOrDefaultAsync(m => m.LegalDocId == id);
            if (legalDocuments == null)
            {
                return NotFound();
            }

            return View(legalDocuments);
        }

        // POST: LegalDocuments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var legalDocuments = await _context.LegalDocuments.FindAsync(id);
            _context.LegalDocuments.Remove(legalDocuments);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LegalDocumentsExists(int id)
        {
            return _context.LegalDocuments.Any(e => e.LegalDocId == id);
        }
    }
}
