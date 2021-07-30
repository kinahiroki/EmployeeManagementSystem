using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementWebUI.Controllers.SCRN9999
{
    public class SCRN9999Controller : Controller
    {
        [Route("/error")]
        [HttpGet]
        [HttpPost]
        public IActionResult Error()
        {
            return View();
        }
    }
}
