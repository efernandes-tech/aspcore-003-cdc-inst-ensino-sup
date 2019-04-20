using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cap02.Data;
using Cap02.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cap02.Controllers
{
    public class DepartamentoController : Controller
    {
        private readonly IESContext _context;

        public DepartamentoController(IESContext context)
        {
            this._context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Departamentos.OrderBy(c => c.Nome).ToListAsync());
        }
    }
}
