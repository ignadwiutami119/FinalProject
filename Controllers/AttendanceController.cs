using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HC_WEB_FINALPROJECT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Text;

namespace HC_WEB_FINALPROJECT.Controllers {
    public class AttendanceController : Controller {
        private AppDbContext _AppDbContext;
        private readonly ILogger<HomeController> _logger;

        public AttendanceController (ILogger<HomeController> logger, AppDbContext appDbContext) {
            _AppDbContext = appDbContext;
            _logger = logger;
        }


        public IActionResult AttendanceList () {
            var now = DateTime.Now;
            var get = now.AddDays(-7);
            ViewBag.items = get;
            return View ("AttendanceList");
        }
         public IActionResult Privacy () {
            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}