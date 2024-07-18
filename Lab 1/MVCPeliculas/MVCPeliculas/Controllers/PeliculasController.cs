using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCPeliculas.Models;

namespace MVCPeliculas.Controllers
{
    public class PeliculasController : Controller
    {
        private readonly PeliculasDBContext _context;

        public PeliculasController(PeliculasDBContext context)
        {
            _context = context;
        }

        // GET: Peliculas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Peliculas.ToListAsync());
        }

        // GET: Peliculas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var peliculas = await _context.Peliculas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (peliculas == null)
            {
                return NotFound();
            }

            return View(peliculas);
        }

        // GET: Peliculas/Create
        public IActionResult Create()
        {
            ViewBag.Genero = new SelectList(_context.Generos, "ID", "Nombre");
            return View();
        }

        // POST: Peliculas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Titulo,FechaLanzmiento,GeneroId,Precio,Director")] Peliculas peliculas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(peliculas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Genero = new SelectList(_context.Generos, "ID", "Nombre", peliculas.GeneroId);
            return View(peliculas);
        }



        // GET: Peliculas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var peliculas = await _context.Peliculas.FindAsync(id);
            if (peliculas == null)
            {
                return NotFound();
            }
            ViewData["GeneroId"] = new SelectList(_context.Generos, "ID", "Nombre", peliculas.GeneroId);
            return View(peliculas);
        }

        // POST: Peliculas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Titulo,FechaLanzmiento,GeneroId,Precio,Director")] Peliculas peliculas)
        {
            if (id != peliculas.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(peliculas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PeliculasExists(peliculas.ID))
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
            ViewData["GeneroId"] = new SelectList(_context.Generos, "ID", "Nombre", peliculas.GeneroId);
            return View(peliculas);

        }
        private bool PeliculasExists(int id)
        {
            return _context.Peliculas.Any(e => e.ID == id);
        }

    }
}
