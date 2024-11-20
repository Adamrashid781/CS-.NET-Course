using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureesController : Controller
    {
        private readonly InsuranceContext _context;

        public InsureesController(InsuranceContext context)
        {
            _context = context;
        }

        // GET: Insurees
        public async Task<IActionResult> Index()
        {
            return View(await _context.Insurees.ToListAsync());
        }

        // GET: Insurees/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // GET: Insurees/Create
        public IActionResult Create()
        {
            return View();
        }

        // Get: Insurees/Admin
        public async Task<IActionResult> Admin(Guid? id)
        {
            return View(await _context.Insurees.ToListAsync());
        }



        // POST: Insurees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Qoute")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // insuree.Id = Guid.NewGuid();
                insuree.Qoute = PriceQuote(insuree); 
                _context.Add(insuree);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(insuree);
        }

        public decimal PriceQuote(Insuree insuree)
        {
            // A
            insuree.Qoute += 50;

            // B
            if (DateTime.Now.Year - insuree.DateOfBirth.Year < 18)
            {
                insuree.Qoute += 100;
            }

            // C
            if (DateTime.Now.Year - insuree.DateOfBirth.Year < 25 && DateTime.Now.Year - insuree.DateOfBirth.Year > 19)
            {
                insuree.Qoute += 50;
            }

            // D
            if(DateTime.Now.Year - insuree.DateOfBirth.Year >= 26)
            {
                insuree.Qoute += 25;
            }

            // E
            if (insuree.CarYear < 2000)
            {
                insuree.Qoute += 25;
            }

            // F
            if(insuree.CarYear > 2015)
            {
                insuree.Qoute += 25;
            }

            // G
            if (insuree.CarMake == "Porsche")
            {
                insuree.Qoute += 25;

                // H
                if (insuree.CarModel.ToLower() == "911 carrera")
                {
                    insuree.Qoute += 25;
                }
            }

            // I 
            if(insuree.SpeedingTickets > 0)
            {
                insuree.Qoute += insuree.SpeedingTickets * 10;
            }

            // Crating variable to base J & K off of normal price, not the %'s
            decimal insurance = insuree.Qoute; 

            // J 
            if(insuree.DUI > 0)
            {
                insuree.Qoute = insuree.Qoute + (insurance * 1.25m);
            }

            // K 
            if(insuree.CoverageType.ToLower() == "full coverage")
            {
                insuree.Qoute = insuree.Qoute + (insurance * 1.50m);
            }




            return insuree.Qoute;

        }

        // GET: Insurees/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees.FindAsync(id);
            if (insuree == null)
            {
                return NotFound();
            }
            return View(insuree);
        }

        // POST: Insurees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Qoute")] Insuree insuree)
        {
            if (id != insuree.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(insuree);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsureeExists(insuree.Id))
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
            return View(insuree);
        }

        

        // GET: Insurees/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // POST: Insurees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var insuree = await _context.Insurees.FindAsync(id);
            if (insuree != null)
            {
                _context.Insurees.Remove(insuree);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsureeExists(Guid id)
        {
            return _context.Insurees.Any(e => e.Id == id);
        }
    }
}
