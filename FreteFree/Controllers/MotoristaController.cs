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
    public class MotoristaController : Controller
    {
        private readonly FreteFreeContext _context;

        public MotoristaController(FreteFreeContext context)
        {
            _context = context;
        }

        // GET: Motorista
        public async Task<IActionResult> Index()
        {
            return View(await _context.Motorista.ToListAsync());
        }

        // GET: Motorista/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motorista = await _context.Motorista
                .FirstOrDefaultAsync(m => m.MotoristaId == id);
            if (motorista == null)
            {
                return NotFound();
            }

            return View(motorista);
        }

        // GET: Motorista/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Motorista/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DataCadastoMotorista,MotoristaId,CaminhaoProprietario,EnderecoProprietario,TelefoneProprietario,TipoCaminhao,PlacaCavalo,CidadeCavalo,EstadoCavalo,PlacaCarreta,CidadeCarreta,EstadoCarreta,NomeMotorista,EnderecoMotorista,TelefoneMovel,TelefoneFixo,CidadeMotorista,EstadoMotorista,CPFMotorista,RGMotorista,CNPJ,Ativo")] Motorista motorista)
        {
            if (ModelState.IsValid)
            {
                _context.Add(motorista);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(motorista);
        }

        // GET: Motorista/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motorista = await _context.Motorista.FindAsync(id);
            if (motorista == null)
            {
                return NotFound();
            }
            return View(motorista);
        }

        // POST: Motorista/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DataCadastoMotorista,MotoristaId,CaminhaoProprietario,EnderecoProprietario,TelefoneProprietario,TipoCaminhao,PlacaCavalo,CidadeCavalo,EstadoCavalo,PlacaCarreta,CidadeCarreta,EstadoCarreta,NomeMotorista,EnderecoMotorista,TelefoneMovel,TelefoneFixo,CidadeMotorista,EstadoMotorista,CPFMotorista,RGMotorista,CNPJ,Ativo")] Motorista motorista)
        {
            if (id != motorista.MotoristaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(motorista);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MotoristaExists(motorista.MotoristaId))
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
            return View(motorista);
        }

        // GET: Motorista/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motorista = await _context.Motorista
                .FirstOrDefaultAsync(m => m.MotoristaId == id);
            if (motorista == null)
            {
                return NotFound();
            }

            return View(motorista);
        }

        // POST: Motorista/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var motorista = await _context.Motorista.FindAsync(id);
            _context.Motorista.Remove(motorista);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MotoristaExists(int id)
        {
            return _context.Motorista.Any(e => e.MotoristaId == id);
        }
    }
}
