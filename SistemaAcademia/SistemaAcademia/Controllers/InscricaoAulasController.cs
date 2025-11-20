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
                          View(await _context.InscricaoAula
                          .Include(i => i.Aluno)
                          .Include(i => i.Aula)
                          .ToListAsync()) :
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
            var viewModel = new InscricaoAulaFormViewModel();
            viewModel.Aulas = _context.Aula.ToList();
            viewModel.Alunos = _context.Aluno.ToList();
            return View(viewModel);
        }

        // POST: InscricaoAulas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DataInscricao,AlunoId,AulaId")] InscricaoAula inscricaoAula)
        {

            // Carregar a aula
            var aula = await _context.Aula.FindAsync(inscricaoAula.AulaId);
            if (aula == null)
            {
                return NotFound();
            }

            // Verificar se há vagas
            if (aula.Vagas <= 0)
            {
                ModelState.AddModelError(string.Empty, "Não há vagas disponíveis.");
                return View(inscricaoAula);
            }

            // Decrementar vaga
            aula.Vagas--;

            _context.Add(inscricaoAula);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


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
            InscricaoAulaFormViewModel viewModel = new InscricaoAulaFormViewModel();
            viewModel.InscricaoAula = inscricaoAula;
            viewModel.Aulas = _context.Aula.ToList();
            viewModel.Alunos = _context.Aluno.ToList();
            return View(viewModel);
        }

        // POST: InscricaoAulas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DataInscricao,AlunoId,AulaId")] InscricaoAula inscricaoAula)
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

        // GET: InscricaoAula/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inscricaoAula = await _context.InscricaoAula
                .Include(i => i.Aluno)
                .Include(i => i.Aula)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inscricaoAula == null)
            {
                return NotFound();
            }

            return View(inscricaoAula);
        }

        // POST: InscricaoAula/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inscricaoAula = await _context.InscricaoAula
                .Include(i => i.Aula)
                .FirstOrDefaultAsync(i => i.Id == id);
            if (inscricaoAula == null)
            {
                return NotFound();
            }

            // Incrementar a vaga
            inscricaoAula.Aula.Vagas++;

            _context.InscricaoAula.Remove(inscricaoAula);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool InscricaoAulaExists(int id)
        {
          return (_context.InscricaoAula?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
