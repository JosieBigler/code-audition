using System.Linq;
using Ilm.CodeAudition.Service;
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
            if(viewModel.Timesheets != null)
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
    }
}