using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2_DPA_FirstMVC.Web.Areas.Marketing.Controllers
{
    [Area("Marketing")]
    public class HomeController : Controller
    {        
        public IActionResult Index()
        {
            return View();
        }
    }
}
