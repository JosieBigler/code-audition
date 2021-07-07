using System.Collections.Generic;
using Ilm.CodeAudition.Service;
using Ilm.CodeAudition.Service.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ilm.CodeAudition.Web.Controllers
{
    public class TimesheetController : Controller
    {
        public ViewResult Index()
        {
            var service = new TimeTrackerService();
            return View(service.GetAll());
        }

        [HttpPost]
        public ViewResult Index(IEnumerable<Timesheet> timesheets)
        {
            foreach (var timesheet in timesheets)
            {
                var service = new TimeTrackerService();
                service.Save(timesheet);
            }
            return View(timesheets);
        }
    }
}