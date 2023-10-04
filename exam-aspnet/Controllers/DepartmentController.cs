using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exam_aspnet.Entities;
using Microsoft.AspNetCore.Mvc;

using exam_aspnet.Models.Department;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace exam_aspnet.Controllers
{
    public class DepartmentController : Controller
    {

        private readonly DataContext _context;

        public DepartmentController(DataContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}

