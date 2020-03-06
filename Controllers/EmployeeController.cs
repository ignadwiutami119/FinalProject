using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HC_WEB_FINALPROJECT.Models;

namespace HC_WEB_FINALPROJECT.Controllers
{
    public class EmployeeController : Controller
    {
        private AppDbContext _AppDbContext;
        private readonly ILogger<HomeController> _logger;

        public EmployeeController(ILogger<HomeController> logger, AppDbContext appDbContext)
        {
            _AppDbContext = appDbContext;
            _logger = logger;
        }

        public IActionResult EmployeeList(int _crntpage=1, string status_employee="permanent")
        {
            var set_page = _AppDbContext.Pagings.Find(1);
            set_page.StatusPage = status_employee;
            set_page.CurentPage = _crntpage;
            _AppDbContext.SaveChanges();
            if (set_page.CurentPage == 1) {
                var take = set_page.ShowItem;
                var spesific_employee = from a in _AppDbContext.Employee where a.Status == set_page.StatusPage select a;
                var get = from a in spesific_employee.Take (take) where a.Status == set_page.StatusPage select a;
                ViewBag.items = get;
                ViewBag.page = set_page;
            } else {
                var take = set_page.ShowItem;
                var spesific_employee = from a in _AppDbContext.Employee where a.Status == set_page.StatusPage select a;
                var get = from a in spesific_employee.Skip (take * (set_page.CurentPage - 1)).Take (take) select a;
                ViewBag.items = get;
                ViewBag.page = set_page;
            }
            return View("EmployeeList");
        }



        public IActionResult EmployeeDetail(int Id)
        {
            var show = _AppDbContext.Employee.Find(Id);
            ViewBag.items = show;
            return View("EmployeeDetail");
        }
        public IActionResult EmployeeUpdate(int Id)
        {
            var show = _AppDbContext.Employee.Find(Id);
            ViewBag.items = show;
            return View("EmployeeUpdate");
        }

        public IActionResult EmployeeUpdateData(int Id, string name, string email, string address, string phone, string occupation, string placement, string emergency)
        {
            var get = _AppDbContext.Employee.Find(Id);
            get.Name = name;
            get.Email = email;
            get.Address = address;
            get.Phone = phone;
            get.Occupation = occupation;
            get.Placement = placement;
            get.EmergencyContact = emergency;
            _AppDbContext.SaveChanges();
            ViewBag.items = get;
            return View("EmployeeDetail");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
