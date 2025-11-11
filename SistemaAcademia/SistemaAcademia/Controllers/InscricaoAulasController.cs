using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaAcademia.Data;
using SistemaAcademia.Models;

namespace SistemaAcademia.Controllers
{
    public class InscricaoAulasController : Controller
    {
        private readonly SistemaAcademiaContext _context;

        public InscricaoAulasController(SistemaAcademiaContext context)
        {
            _context = context;
        }

        // GET: InscricaoAulas
        public async Task<IActionResult> Index()
        {
              return _context.InscricaoAula != null ? 
                          View(await _context.InscricaoAula.ToListAsync()) :
                          Problem("Entity set 'SistemaAcademiaContext.InscricaoAula'  is null.");
        }

        // GET: InscricaoAulas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.InscricaoAula == null)
            {
                return NotFound();
            }

            var inscricaoAula = await _context.InscricaoAula
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inscricaoAula == null)
            {
                return NotFound();
            }

            return View(inscricaoAula);
        }

        // GET: InscricaoAulas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: InscricaoAulas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DataInscricao")] InscricaoAula inscricaoAula)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inscricaoAula);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(inscricaoAula);
        }

        // GET: InscricaoAulas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.InscricaoAula == null)
            {
                return NotFound();
            }

            var inscricaoAula = await _context.InscricaoAula.FindAsync(id);
            if (inscricaoAula == null)
            {
                return NotFound();
            }
            return View(inscricaoAula);
        }

        // POST: InscricaoAulas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DataInscricao")] InscricaoAula inscricaoAula)
        {
            if (id != inscricaoAula.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inscricaoAula);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InscricaoAulaExists(inscricaoAula.Id))
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
            return View(inscricaoAula);
        }

        // GET: InscricaoAulas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.InscricaoAula == null)
            {
                return NotFound();
            }

            var inscricaoAula = await _context.InscricaoAula
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inscricaoAula == null)
            {
                return NotFound();
            }

            return View(inscricaoAula);
        }

        // POST: InscricaoAulas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.InscricaoAula == null)
            {
                return Problem("Entity set 'SistemaAcademiaContext.InscricaoAula'  is null.");
            }
            var inscricaoAula = await _context.InscricaoAula.FindAsync(id);
            if (inscricaoAula != null)
            {
                _context.InscricaoAula.Remove(inscricaoAula);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InscricaoAulaExists(int id)
        {
          return (_context.InscricaoAula?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
