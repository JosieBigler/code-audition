using System.Linq;
using Ilm.CodeAudition.Service;
using Ilm.CodeAudition.Service.Models;
using Ilm.CodeAudition.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ilm.CodeAudition.Web.Controllers
{
    public class TimesheetController : Controller
    {
        private TimesheetContext _dbConext;

        public TimesheetController(TimesheetContext dbContext)
        {
            _dbConext = dbContext;
        }

        public ActionResult Index()
        {
            var employee = _dbConext.Employees.Find(1);

            var viewModel = new TimesheetViewModel()
            {
                Timesheets = _dbConext.Timesheets.Where(t => t.EmployeeId == employee.Id).ToList(),
                Employee = employee
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(TimesheetViewModel viewModel)
        {
            var employee = _dbConext.Employees.Find(1);

            viewModel.Employee = employee;

            if (viewModel.Timesheets != null)
            {
                foreach (var timesheet in viewModel.Timesheets)
                {
                    timesheet.Total = timesheet.Monday + timesheet.Tuesday + timesheet.Wednesday + timesheet.Thursday + timesheet.Friday;
                    _dbConext.Update(timesheet);
                    _dbConext.SaveChanges();
                }
            }

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult AddProject(string projectName)
        {
            var newTimesheet = new Timesheet()
            {
                EmployeeId = 1,
                ProjectName = projectName
            };

            _dbConext.Add(newTimesheet);
            _dbConext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}