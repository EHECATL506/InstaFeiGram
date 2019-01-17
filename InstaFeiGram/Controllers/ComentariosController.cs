using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InstaFeiGram.Data;
using InstaFeiGram.Models;

namespace InstaFeiGram.Controllers
{
    public class ComentariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComentariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Comentarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Comentario.ToListAsync());
        }

        // GET: Comentarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comentario = await _context.Comentario
                .FirstOrDefaultAsync(m => m.idcomentario == id);
            if (comentario == null)
            {
                return NotFound();
            }

            return View(comentario);
        }

        public IActionResult Create(int FotoId)
        {
            ViewBag.ListaDeComentarios = _context.Foto.Where(x => x.idfoto == FotoId)
                                       .Select(x => x.Comentarios).FirstOrDefault();
            ViewBag.Fotoruta = _context.Foto.Where(x => x.idfoto == FotoId)
                                        .Select(x => x.rutaimagen).FirstOrDefault();
            ViewBag.FotoTitulo = _context.Foto.Where(x => x.idfoto == FotoId)
                                        .Select(x => x.titulo).FirstOrDefault();
            ViewBag.Fotoresumen = _context.Foto.Where(x => x.idfoto == FotoId)
                                       .Select(x => x.resumen).FirstOrDefault();
            ViewBag.Fotousuario = _context.Foto.Where(x => x.idfoto == FotoId)
                                       .Select(x => x.correousuario).FirstOrDefault();
            ViewBag.FotoFecha = _context.Foto.Where(x => x.idfoto == FotoId)
                                       .Select(x => x.fechasubida).FirstOrDefault();
            ViewBag.FotoId = FotoId;
            ContarVisitas(FotoId);
            return View();
        }



        // POST: Comentarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Comentario comentario, int FotoId)
        {
            if (ModelState.IsValid)
            {   
                comentario.correousuario = HttpContext.User.Identity.Name;
                ViewBag.Ruta = _context.Foto.Where(x => x.idfoto == FotoId).Select(x => x.rutaimagen).FirstOrDefault();
                comentario.imgdatos = _context.Foto.Find(FotoId);
                _context.Add(comentario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create), new {FotoId});
            }
            return View(comentario);
        }


        public IActionResult ContarVisitas(int idFoto)
        {
            var foto = _context.Foto.Find(idFoto);
            foto.numvisitas = foto.numvisitas + 1;
            _context.Update(foto);
            _context.SaveChanges();
            return RedirectToAction("Index, Fotoes");
        }

        // GET: Comentarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comentario = await _context.Comentario.FindAsync(id);
            if (comentario == null)
            {
                return NotFound();
            }
            return View(comentario);
        }

        // POST: Comentarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,  Comentario comentario)
        {
            if (id != comentario.idcomentario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comentario);
                    _context.Entry(comentario).Property("correousuario").IsModified = false;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComentarioExists(comentario.idcomentario))
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
            return View(comentario);
        }

        // GET: Comentarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comentario = await _context.Comentario
                .FirstOrDefaultAsync(m => m.idcomentario == id);
            if (comentario == null)
            {
                return NotFound();
            }

            return View(comentario);
        }

        // POST: Comentarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var comentario = await _context.Comentario.FindAsync(id);
            _context.Comentario.Remove(comentario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComentarioExists(int id)
        {
            return _context.Comentario.Any(e => e.idcomentario == id);
        }
    }
}
