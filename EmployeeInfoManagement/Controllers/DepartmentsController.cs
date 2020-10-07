using EInfo.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeInfoManagement.Controllers
{
    public class DepartmentsController : Controller
    {
        // GET: Departments
        public ActionResult New()
        {
            var vm = new DeparemeentVM() { IsActive = true };
            return View(vm);
        }
    }
}