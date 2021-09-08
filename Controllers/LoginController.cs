using CRUDPRACTICAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDPRACTICAL.Controllers
{
    public class LoginController : Controller
    {
        public EmployeeContext _context;
        public object Context { get; private set; }
        public LoginController(EmployeeContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(Employee obj)
        {
            var row = _context.Employees.Where(model => model.Email == obj.Email && model.Password == obj.Password).FirstOrDefault();


            if (row != null)
            {
                TempData["Issuccess-Login"] = true;
                return RedirectToAction("Index", new { Issuccess = true });

            }
            else
            {
                TempData["Issuccess-Error"] = true;
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> IndexAsync(string Empsearch, int currentPageIndex)
        {
            if (currentPageIndex == 0)
            {
                currentPageIndex = 1;
            }
            // ViewData["Getemployeedetails"] = Empsearch;
            var empquery = from x in _context.Employees select x;
            var emppages = _context.Employees.AsNoTracking();
            var numbercount = emppages.Count();
            var model = await PagingList<Employee>.CreateAsync((IOrderedQueryable<Employee>)emppages, 4, currentPageIndex);
            if (!string.IsNullOrEmpty(Empsearch))
            {
                //empquery = (IQueryable<Employee>)empquery.Where(x => x.FullName.Contains(Empsearch) || x.EmpCode.Contains(Empsearch) || x.Position.Contains(Empsearch) || x.OfficeLocation.Contains(Empsearch) || x.Gender.Contains(Empsearch) || Empsearch==null).ToList().ToPagedList(id ?? 1,3);
                empquery = empquery.Where(x => x.FullName.Contains(Empsearch) || x.EmpCode.Contains(Empsearch) || x.Position.Contains(Empsearch) || x.OfficeLocation.Contains(Empsearch) || x.Gender.Contains(Empsearch));
            }
            if (TempData["Issuccess-Login"] == null)
            {
                TempData["Issuccess-Login"] = false;
            }
            if (TempData["Issuccess-Error"] == null)
            {
                TempData["Issuccess-Error"] = false;
            }

            //return View(model: await empquery.AsNoTracking().ToListAsync());

            return View(model);
        }
    }
}
