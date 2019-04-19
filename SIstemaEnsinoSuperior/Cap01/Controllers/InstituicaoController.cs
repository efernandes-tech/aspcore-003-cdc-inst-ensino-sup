using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cap01.Controllers
{
    public class InstituicaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}