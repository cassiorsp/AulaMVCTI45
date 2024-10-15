using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MeuPrimeiroAsp.Data;
using MeuPrimeiroAsp.Models;

namespace MeuPrimeiroAsp.Controllers
{
    public class RepresentanteController : Controller
    {
        private readonly DataContext _context;

        public RepresentanteController(DataContext context)
        {
            _context = context;
        }

        // GET: Representante
        public async Task<IActionResult> Index()
        {
            return View(await _context.Representantes.ToListAsync());
        }

        // GET: Representante/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var representanteModel = await _context.Representantes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (representanteModel == null)
            {
                return NotFound();
            }

            return View(representanteModel);
        }

        // GET: Representante/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Representante/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,RazaoSocial,CPF,CNPJ,Email,Telefone,Celular")] RepresentanteModel representanteModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(representanteModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(representanteModel);
        }

        // GET: Representante/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var representanteModel = await _context.Representantes.FindAsync(id);
            if (representanteModel == null)
            {
                return NotFound();
            }
            return View(representanteModel);
        }

        // POST: Representante/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,RazaoSocial,CPF,CNPJ,Email,Telefone,Celular")] RepresentanteModel representanteModel)
        {
            if (id != representanteModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(representanteModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RepresentanteModelExists(representanteModel.Id))
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
            return View(representanteModel);
        }

        // GET: Representante/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var representanteModel = await _context.Representantes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (representanteModel == null)
            {
                return NotFound();
            }

            return View(representanteModel);
        }

        // POST: Representante/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var representanteModel = await _context.Representantes.FindAsync(id);
            if (representanteModel != null)
            {
                _context.Representantes.Remove(representanteModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RepresentanteModelExists(int id)
        {
            return _context.Representantes.Any(e => e.Id == id);
        }
    }
}
