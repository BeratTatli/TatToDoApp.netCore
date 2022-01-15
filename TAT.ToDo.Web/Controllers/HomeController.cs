using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TAT.ToDo.Web.Models;

namespace TAT.ToDo.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new List<MüşteriViewModel>()
            {
                new MüşteriViewModel(){Ad="Berat"},
                new MüşteriViewModel(){Ad="Berat2"},
                new MüşteriViewModel(){Ad="Berat3"},
                new MüşteriViewModel(){Ad="Berat4"},
                new MüşteriViewModel(){Ad="Berat5"},
            });
        }
    }
}
