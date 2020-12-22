using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FreteFree.Data;
using FreteFree.Models.Motorista;

namespace FreteFree.Controllers
{
    public class OrdemCarregamentoController : Controller
    {
        private readonly FreteFreeContext _context;

        public OrdemCarregamentoController(FreteFreeContext context)
        {
            _context = context;
        }

        // GET: OrdemCarregamento
        public async Task<IActionResult> Index()
        {
            var freteFreeContext = _context.OrdemCarregamento.Include(o => o.Empresa).Include(o => o.Motorista);
            return View(await freteFreeContext.ToListAsync());
        }

        // GET: OrdemCarregamento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordemCarregamento = await _context.OrdemCarregamento
                .Include(o => o.Empresa)
                .Include(o => o.Motorista)
                .FirstOrDefaultAsync(m => m.OrdemCarregamentoId == id);
            if (ordemCarregamento == null)
            {
                return NotFound();
            }

            return View(ordemCarregamento);
        }

        // GET: OrdemCarregamento/Create
        public IActionResult Create()
        {
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "EmpresaId", "CidadeEmpresa");
            ViewData["MotoristaId"] = new SelectList(_context.Motorista, "MotoristaId", "CaminhaoProprietario");
            return View();
        }

        // POST: OrdemCarregamento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrdemCarregamentoId,EmpresaId,MotoristaId,Valor,Medida,DataOrdemCarregamento,Destino,TipoCarga,Ativo")] OrdemCarregamento ordemCarregamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ordemCarregamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "EmpresaId", "CidadeEmpresa", ordemCarregamento.EmpresaId);
            ViewData["MotoristaId"] = new SelectList(_context.Motorista, "MotoristaId", "CaminhaoProprietario", ordemCarregamento.MotoristaId);
            return View(ordemCarregamento);
        }

        // GET: OrdemCarregamento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordemCarregamento = await _context.OrdemCarregamento.FindAsync(id);
            if (ordemCarregamento == null)
            {
                return NotFound();
            }
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "EmpresaId", "CidadeEmpresa", ordemCarregamento.EmpresaId);
            ViewData["MotoristaId"] = new SelectList(_context.Motorista, "MotoristaId", "CaminhaoProprietario", ordemCarregamento.MotoristaId);
            return View(ordemCarregamento);
        }

        // POST: OrdemCarregamento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrdemCarregamentoId,EmpresaId,MotoristaId,Valor,Medida,DataOrdemCarregamento,Destino,TipoCarga,Ativo")] OrdemCarregamento ordemCarregamento)
        {
            if (id != ordemCarregamento.OrdemCarregamentoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ordemCarregamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdemCarregamentoExists(ordemCarregamento.OrdemCarregamentoId))
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
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "EmpresaId", "CidadeEmpresa", ordemCarregamento.EmpresaId);
            ViewData["MotoristaId"] = new SelectList(_context.Motorista, "MotoristaId", "CaminhaoProprietario", ordemCarregamento.MotoristaId);
            return View(ordemCarregamento);
        }

        // GET: OrdemCarregamento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordemCarregamento = await _context.OrdemCarregamento
                .Include(o => o.Empresa)
                .Include(o => o.Motorista)
                .FirstOrDefaultAsync(m => m.OrdemCarregamentoId == id);
            if (ordemCarregamento == null)
            {
                return NotFound();
            }

            return View(ordemCarregamento);
        }

        // POST: OrdemCarregamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ordemCarregamento = await _context.OrdemCarregamento.FindAsync(id);
            _context.OrdemCarregamento.Remove(ordemCarregamento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrdemCarregamentoExists(int id)
        {
            return _context.OrdemCarregamento.Any(e => e.OrdemCarregamentoId == id);
        }
    }
}
