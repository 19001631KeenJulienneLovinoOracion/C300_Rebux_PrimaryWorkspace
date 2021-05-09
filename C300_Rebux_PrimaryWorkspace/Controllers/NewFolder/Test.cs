using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C300_Rebux_PrimaryWorkspace.Controllers.NewFolder
{
    public class Test : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
