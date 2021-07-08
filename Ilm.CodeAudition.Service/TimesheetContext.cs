using Ilm.CodeAudition.Service.Models;
using Microsoft.EntityFrameworkCore;

namespace Ilm.CodeAudition.Service
{
    public class TimesheetContext : DbContext
    {
        public TimesheetContext(DbContextOptions<TimesheetContext> options)
            : base(options)
        {
        }

        public DbSet<Timesheet> Timesheets { get; set; }

    }
}