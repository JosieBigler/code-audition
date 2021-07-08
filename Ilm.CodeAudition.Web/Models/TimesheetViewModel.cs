using Ilm.CodeAudition.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ilm.CodeAudition.Web.Models
{
    public class TimesheetViewModel
    {
        public IList<Timesheet> Timesheets { get; set; }
    }
}
