using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InstaFeiGram.Data;
using InstaFeiGram.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using System.IO;

namespace InstaFeiGram.Controllers
{
    [Authorize]

    public class FotoesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _hosting;

        public FotoesController(ApplicationDbContext context, IHostingEnvironment hosting)
        {
            _context = context;
            _hosting = hosting;
        }

        // GET: Fotoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Foto.ToListAsync());
        }

        // GET: Fotoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var foto = await _context.Foto
                .FirstOrDefaultAsync(m => m.idfoto == id);
             ContarVisitas(id.Value);
            if (foto == null)
            {
                return NotFound();
            }

            return View(foto);
        }

        // GET: Fotoes/Create
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult ContarVisitas(int idFoto)
        {
            var foto = _context.Foto.Find(idFoto);
            foto.numvisitas = foto.numvisitas + 1;
            _context.Update(foto);
            _context.SaveChanges();
            return RedirectToAction("Index, Fotoes");
        }

        public IActionResult PerfilUsuarios()
        {
            var correo = HttpContext.User.Identity.Name;
            var fotografias = _context.Foto.Where(x => x.correousuario == correo).ToList();
            return View(fotografias);
        }

        public IActionResult Perfiles(String usuario)
        {         
            var fotografias = _context.Foto.Where(x => x.correousuario == usuario).ToList();
           ///ViewBag.Usuario = _context.Foto.Where(x => x.correousuario == usuario).FirstOrDefault();
            return View(fotografias); 
        }

        public async Task<IActionResult> Recientes() {
            var fotografias = from f in _context.Foto
                              orderby f.fechasubida descending
                              select f;

            return View(await fotografias.ToListAsync());
                }

        public async Task<IActionResult> Comentadas(){
            var fotografias = from f in _context.Foto
                              orderby f.numvisitas descending
                              select f;

            return View(await fotografias.ToListAsync());
        }

        public async Task<IActionResult> Votadas()
        {
            var fotografias = from f in _context.Foto
                              orderby f.gusta descending
                              select f;

            return View(await fotografias.ToListAsync());
        }

        public async Task<IActionResult> Buscar([Bind("Buscartodo")]string Buscartodo)
        {
            var fotoes = from m in _context.Foto
                         select m;           
            if (!String.IsNullOrEmpty(Buscartodo))
            {
                fotoes = fotoes.Where(s => s.titulo.Contains(Buscartodo)
                               || s.tag.Contains(Buscartodo) || s.correousuario.Contains(Buscartodo));
            }
            return View(await fotoes.ToListAsync());
        }

        public IActionResult DarGusta(int idFoto)
        {
            var foto = _context.Foto.Find(idFoto);
            foto.gusta = foto.gusta + 1;
            _context.Update(foto);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: Fotoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Foto foto, IFormFile imagen)
        {
            if (ModelState.IsValid)
            {
                foto.numvisitas = 0;
                foto.fechasubida = DateTime.Now;
                var nombre = Guid.NewGuid().ToString() + Path.GetExtension(imagen.FileName);
                var path = Path.Combine(_hosting.WebRootPath, "images", nombre);
                //var path2 = Path.Combine(_hosting.WebRootPath, "Filtros", nombre);
                imagen.CopyTo(new FileStream(path, FileMode.Create));
               // imagen.CopyTo(new FileStream(path2, FileMode.Create));
                foto.correousuario= HttpContext.User.Identity.Name;
                foto.rutaimagen = nombre;
                _context.Add(foto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(foto);
        }


        // GET: Fotoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foto = await _context.Foto.FindAsync(id);
            if (foto == null)
            {
                return NotFound();
            }
            return View(foto);
        }

        // POST: Fotoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Foto foto)
        {
            if (id != foto.idfoto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    _context.Update(foto);
                    _context.Entry(foto).Property("fechasubida").IsModified = false;
                    _context.Entry(foto).Property("rutaimagen").IsModified = false;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FotoExists(foto.idfoto))
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
            return View(foto);
        }

        // GET: Fotoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foto = await _context.Foto
                .FirstOrDefaultAsync(m => m.idfoto == id);
            if (foto == null)
            {
                return NotFound();
            }

            return View(foto);
        }

        // POST: Fotoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var foto = await _context.Foto.FindAsync(id);
            _context.Foto.Remove(foto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FotoExists(int id)
        {
            return _context.Foto.Any(e => e.idfoto == id);
        }
    }
}
