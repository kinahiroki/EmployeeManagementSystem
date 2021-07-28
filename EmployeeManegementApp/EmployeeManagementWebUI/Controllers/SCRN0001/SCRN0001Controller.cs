using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementWebUI.Controllers.SCRN0001
{
    /// <summary>
    /// 
    /// </summary>
    public class SCRN0001Controller : Controller
    {
        [Route("")]
        [Route("/employee/menu")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
