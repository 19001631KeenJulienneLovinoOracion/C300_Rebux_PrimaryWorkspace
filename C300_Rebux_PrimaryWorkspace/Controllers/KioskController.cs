using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace C300_Rebux_PrimaryWorkspace.Controllers
{
    public class KioskController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
