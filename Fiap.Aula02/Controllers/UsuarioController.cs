using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Aula02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula02.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario)
        {
            TempData["msg"] = "Usuario cadastrado";
            return View(usuario);
        }
    }
}
