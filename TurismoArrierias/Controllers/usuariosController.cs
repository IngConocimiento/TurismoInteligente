using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurismoArrierias.Datos;
using TurismoArrierias.Models;

namespace TurismoArrierias.Controllers
{
    public class usuariosController : Controller
    {
        private readonly AplicationDBcontext contexto;

        public usuariosController(AplicationDBcontext contexto)
        {
            this.contexto = contexto;
        }

        public IActionResult Index()
        {
            IEnumerable<usuario> listaUsuarios = contexto.Usuario;
            return View(listaUsuarios);
        }
        public IActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Crear(usuario u)
        {
            if (ModelState.IsValid)
            {
                contexto.Usuario.Add(u);
                contexto.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
        public IActionResult Editar(int? id)
        {
            usuario u = contexto.Usuario.Find(id);
            if (u == null)
                return NotFound();
            return View(u);
        }

        [HttpPost]
        public IActionResult Editar(usuario u)
        {
            if (ModelState.IsValid)
            {
                contexto.Usuario.Update(u);
                contexto.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Borrar(int? id)
        {
            usuario u = contexto.Usuario.Find(id);
            if (u == null)
                return NotFound();
            contexto.Usuario.Remove(u);
            contexto.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
