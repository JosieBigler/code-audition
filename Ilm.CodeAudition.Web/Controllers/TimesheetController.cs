using System.Collections.Generic;
using Ilm.CodeAudition.Service;
using Ilm.CodeAudition.Service.Models;
using Ilm.CodeAudition.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ilm.CodeAudition.Web.Controllers
{
    public class TimesheetController : Controller
    {
        public TimesheetController()
        {

        }

        public ViewResult Index()
        {
            var service = new TimeTrackerService();

            var viewModel = new TimesheetViewModel()
            {
                Timesheets = service.GetAll()
            };

            return View(viewModel);
        }

        [HttpPost]
        public ViewResult Index(TimesheetViewModel viewModel)
        {
            foreach (var timesheet in viewModel.Timesheets)
            {
                var service = new TimeTrackerService();
                service.Save(timesheet);
            }
            return View(viewModel);
        }
    }
}