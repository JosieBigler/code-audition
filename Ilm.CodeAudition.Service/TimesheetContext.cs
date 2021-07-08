using Ilm.CodeAudition.Service.Models;
using Microsoft.EntityFrameworkCore;

namespace Ilm.CodeAudition.Service
{
    public class TimesheetContext : DbContext
    {
        public TimesheetContext()
        {
        }

        public TimesheetContext(DbContextOptions<TimesheetContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Data Source=../Ilm.CodeAudition.Service/Ilm.CodeAudition.Service.db");
            }
        }

        public DbSet<Timesheet> Timesheets { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}