using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tankdaten.Data;
using Tankdaten.Models;
//MoviesController.cs
namespace Tankdaten.Controllers
{
    public class TankdatenViewModelsController : Controller
    {
        private readonly TankdatenContext _context;

        public TankdatenViewModelsController(TankdatenContext context)
        {
            _context = context;
        }

        // GET: TankdatenViewModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.TankdatenViewModel.ToListAsync());
        }

        // GET: TankdatenViewModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tankdatenViewModel = await _context.TankdatenViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tankdatenViewModel == null)
            {
                return NotFound();
            }

            return View(tankdatenViewModel);
        }

        // GET: TankdatenViewModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TankdatenViewModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fahrzeug,GetanktAm,Kosten")] TankdatenViewModel tankdatenViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tankdatenViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tankdatenViewModel);
        }

        // GET: TankdatenViewModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tankdatenViewModel = await _context.TankdatenViewModel.FindAsync(id);
            if (tankdatenViewModel == null)
            {
                return NotFound();
            }
            return View(tankdatenViewModel);
        }

        // POST: TankdatenViewModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fahrzeug,GetanktAm,Kosten")] TankdatenViewModel tankdatenViewModel)
        {
            if (id != tankdatenViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tankdatenViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TankdatenViewModelExists(tankdatenViewModel.Id))
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
            return View(tankdatenViewModel);
        }

        // GET: TankdatenViewModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tankdatenViewModel = await _context.TankdatenViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tankdatenViewModel == null)
            {
                return NotFound();
            }

            return View(tankdatenViewModel);
        }

        // POST: TankdatenViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tankdatenViewModel = await _context.TankdatenViewModel.FindAsync(id);
            if (tankdatenViewModel != null)
            {
                _context.TankdatenViewModel.Remove(tankdatenViewModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TankdatenViewModelExists(int id)
        {
            return _context.TankdatenViewModel.Any(e => e.Id == id);
        }

        [HttpGet]
        public async Task<JsonResult> GetTankdaten()
        {
            var tankdaten = await _context.TankdatenViewModel
                .Select(t => new { t.GetanktAm, t.Kosten })
                .ToListAsync();

            return Json(tankdaten);
        }
        public IActionResult Charts()
        {
            return View();
        }


    }
}
