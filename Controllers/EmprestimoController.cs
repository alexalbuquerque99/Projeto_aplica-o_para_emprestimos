using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Projeto_aplicação_para_emprestimos.Data;
using Projeto_aplicação_para_emprestimos.Models;
using System.Collections.Generic;

namespace Projeto_aplicação_para_emprestimos.Controllers
{
    public class EmprestimoController : Controller
    {
        readonly private ApplicationDbContext _db;
        public EmprestimoController(ApplicationDbContext db)
        {
            _db = db;
        }

        public int EmprestimosModel { get; private set; }

        public IActionResult Index()
        {
            IEnumerable<Emprestimosmodel> emprestimos = _db.Emprestimos;

            return View(emprestimos);
        }
    }

    
 }

