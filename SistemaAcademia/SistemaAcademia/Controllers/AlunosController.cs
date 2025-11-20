using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaAcademia.Data;
using SistemaAcademia.Models;
using SistemaAcademia.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAcademia.Controllers
{
    public class AlunosController : Controller
    {
        private readonly SistemaAcademiaContext _context;

        public AlunosController(SistemaAcademiaContext context)
        {
            _context = context;
        }

        // GET: Alunos
        public async Task<IActionResult> Index()
        {
              return _context.Aluno != null ? 
                          View(await _context.Aluno
                          .Include(a => a.Plano)
                          .ToListAsync()) :
                          Problem("Entity set 'SistemaAcademiaContext.Aluno'  is null.");
        }

        // GET: Alunos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Aluno == null)
            {
                return NotFound();
            }

            var aluno = await _context.Aluno
                .Include(a => a.Plano)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aluno == null)
            {
                return NotFound();
            }

            return View(aluno);
        }

        // GET: Alunos/Create
        public IActionResult Create()
        {
            var viewModel = new AlunoFormViewModel();
            viewModel.Planos = _context.Plano.ToList();
            return View(viewModel);
        }

        // POST: Alunos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Cpf,Email,Telefone,DataNasc,PlanoId")] Aluno aluno)
        {
           
                _context.Add(aluno);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
        }

        // GET: Alunos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Aluno == null)
            {
                return NotFound();
            }

            var aluno = await _context.Aluno.FindAsync(id);
            if (aluno == null)
            {
                return NotFound();
            }
            AlunoFormViewModel viewModel = new AlunoFormViewModel();
            viewModel.Aluno = aluno;
            viewModel.Planos = _context.Plano.ToList();
            return View(viewModel);
        }

        // POST: Alunos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Cpf,Email,Telefone,DataNasc,PlanoId")] Aluno aluno)
        {
            if (id != aluno.Id)
            {
                return NotFound();
            }

                try
                {
                    _context.Update(aluno);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlunoExists(aluno.Id))
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

        // GET: Alunos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Aluno == null)
            {
                return NotFound();
            }

            var aluno = await _context.Aluno
                .Include(a => a.Plano)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aluno == null)
            {
                return NotFound();
            }

            return View(aluno);
        }

        // POST: Alunos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Aluno == null)
            {
                return Problem("Entity set 'SistemaAcademiaContext.Aluno'  is null.");
            }
            var aluno = await _context.Aluno.FindAsync(id);
            if (aluno != null)
            {
                _context.Aluno.Remove(aluno);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlunoExists(int id)
        {
          return (_context.Aluno?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
