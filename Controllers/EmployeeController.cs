using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRUDPRACTICAL.Models;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PagedList;
using ReflectionIT.Mvc.Paging;
using Microsoft.AspNetCore.Identity;
using Microsoft.Azure.Documents;

namespace CRUDPRACTICAL.Controllers
{
    public class EmployeeController : Controller
    {
      public EmployeeContext _context;

        public object Context { get; private set; }

        public EmployeeController(EmployeeContext context)
        {
            _context = context;

        }

       

       
        [HttpGet]
        public async Task<IActionResult> IndexAsync(string Empsearch, int currentPageIndex)
        {
            if (currentPageIndex == 0)
            {
                currentPageIndex = 1;
            }
            ViewData["Getemployeedetails"] = Empsearch;
            var empquery = from x in _context.Employees select x;
            var emppages = _context.Employees.AsNoTracking();
            var numbercount = emppages.Count();
             var model = await PagingList<Employee>.CreateAsync((IOrderedQueryable<Employee>)emppages,4, currentPageIndex);
            if (!string.IsNullOrEmpty(Empsearch))
            {
                //empquery = (IQueryable<Employee>)empquery.Where(x => x.FullName.Contains(Empsearch) || x.EmpCode.Contains(Empsearch) || x.Position.Contains(Empsearch) || x.OfficeLocation.Contains(Empsearch) || x.Gender.Contains(Empsearch) || Empsearch==null).ToList().ToPagedList(id ?? 1,3);
                empquery = empquery.Where(x => x.FullName.Contains(Empsearch) || x.EmpCode.Contains(Empsearch) || x.Position.Contains(Empsearch) || x.OfficeLocation.Contains(Empsearch) || x.Gender.Contains(Empsearch));
            }

            if (TempData["Issuccess-save"] == null)
            {
                TempData["Issuccess-save"] = false;
            }
            if (TempData["Issuccess-delete"] == null)
            {
                TempData["Issuccess-delete"] = false;
            }
             if (TempData["Issuccess"] == null)
            {
                TempData["Issuccess"] = false;
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

        public ActionResult Create(bool Issucess)
        {
            ViewBag.issuccess = Issucess;
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee obj)
        {
            int id = obj.EmployeeId;
            {
                _context.Employees.Add(obj);
                _context.SaveChanges();
                TempData["Issuccess-save"] = true;
                return RedirectToAction("Index", new { Issuccess = true });
                //ViewBag.issuccess = true;
                //return RedirectToAction(nameof(Index));
                //return RedirectToAction("Create", new { Issuccess = true });
                //ModelState.Clear();
            }
            //return View();
        }
        /*public async Task<IActionResult> Create([Bind("EmployeeId,FullName,EmpCode,Position,OfficeLocation,Gender")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                if(employee.EmployeeId==0)
                _context.Add(employee);
               *//* else if (searchBy == "Gender")

                _context.Employees.Where(x => x.Gender == searchvalue).ToList();
               *//*
                else
                   // _context.Employees.Where(x => x.FullName == searchvalue).ToList();
                _context.Update(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }
*/

        // [ValidateAntiForgeryToken]

        /* public async Task<IActionResult> Edit([Bind("EmployeeId,FullName,EmpCode,Position,OfficeLocation,Gender")] Employee employee)
         {
             if (ModelState.IsValid)
             {
                 if (employee.EmployeeId == 0)
                     _context.Add(employee);

                 else
                     // _context.Employees.Where(x => x.FullName == searchvalue).ToList();
                     _context.Update(employee);
                 await _context.SaveChangesAsync();
                 return RedirectToAction(nameof(Index));
             }
             return View(employee);
         }
 */


        public ActionResult Edit(int id)
        {
            var model = _context.Employees.Find(id);
            return View(model);
        }


        [HttpPost]
        public ActionResult Edit(Employee obj)
        {
            if (ModelState.IsValid)
            {
                int Id = obj.EmployeeId;
                {
                    _context.Employees.Update(obj);
                    //_context.Entry(obj).State = EntityState.Modified;
                    _context.SaveChanges();
                    TempData["Issuccess"] = true;
                    //ViewBag.issuccess = true;

                    return RedirectToAction("Index", new { Issuccess = true });
                }
            }
            return View(obj);
        }





        private bool EmployeeExists(int employeeId)
        {
            throw new NotImplementedException();
        }

       public ActionResult Delete(int Id)
        {
            if (ModelState.IsValid) { 
            var employee =  _context.Employees.Find(Id);
            _context.Employees.Remove(employee);
                _context.SaveChanges();
                TempData["Issuccess-delete"] = true;
            }
                return RedirectToAction("Index");
            /* return View(obj);*/
        }
    }

}
