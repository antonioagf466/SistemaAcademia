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
    public class ManutencoesController : Controller
    {
        private readonly SistemaAcademiaContext _context;

        public ManutencoesController(SistemaAcademiaContext context)
        {
            _context = context;
        }

        // GET: Manutencoes
        public async Task<IActionResult> Index()
        {
              return _context.Manutencao != null ? 
                          View(await _context.Manutencao.ToListAsync()) :
                          Problem("Entity set 'SistemaAcademiaContext.Manutencao'  is null.");
        }

        // GET: Manutencoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Manutencao == null)
            {
                return NotFound();
            }

            var manutencao = await _context.Manutencao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (manutencao == null)
            {
                return NotFound();
            }

            return View(manutencao);
        }

        // GET: Manutencoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Manutencoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tipo,Data,Tecnico,Observacao,Custo")] Manutencao manutencao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(manutencao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(manutencao);
        }

        // GET: Manutencoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Manutencao == null)
            {
                return NotFound();
            }

            var manutencao = await _context.Manutencao.FindAsync(id);
            if (manutencao == null)
            {
                return NotFound();
            }
            return View(manutencao);
        }

        // POST: Manutencoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tipo,Data,Tecnico,Observacao,Custo")] Manutencao manutencao)
        {
            if (id != manutencao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(manutencao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ManutencaoExists(manutencao.Id))
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
            return View(manutencao);
        }

        // GET: Manutencoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Manutencao == null)
            {
                return NotFound();
            }

            var manutencao = await _context.Manutencao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (manutencao == null)
            {
                return NotFound();
            }

            return View(manutencao);
        }

        // POST: Manutencoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Manutencao == null)
            {
                return Problem("Entity set 'SistemaAcademiaContext.Manutencao'  is null.");
            }
            var manutencao = await _context.Manutencao.FindAsync(id);
            if (manutencao != null)
            {
                _context.Manutencao.Remove(manutencao);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ManutencaoExists(int id)
        {
          return (_context.Manutencao?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
