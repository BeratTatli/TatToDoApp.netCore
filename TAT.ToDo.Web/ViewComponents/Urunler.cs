using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TAT.ToDo.Web.Models;

namespace TAT.ToDo.Web.ViewComponents
{
    public class Urunler : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
            
        }
    }
}
