using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Aula02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula02.Controllers
{
    public class ProdutoController : Controller
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
        public IActionResult Cadastrar(Produto produto)
        {
            ViewData["nome"] = produto.Nome;
            ViewBag.prod = produto;
            TempData["msg"] = "Produto cadastrado";
            //return RedirectToAction("Cadastrar");
            return View(produto); // Envia o objeto inteiro para a view
        }


    }
}
