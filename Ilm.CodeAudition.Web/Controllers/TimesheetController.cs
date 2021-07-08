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
            var viewModel = new TimesheetViewModel()
            {
                Timesheets = _dbConext.Timesheets.ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(TimesheetViewModel viewModel)
        {
            foreach (var timesheet in viewModel.Timesheets)
            {
                _dbConext.Update(timesheet);
                _dbConext.SaveChanges();
            }

            return View(viewModel);
        }
    }
}