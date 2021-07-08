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
                options.UseSqlServer("Server=tcp:codeaudition.database.windows.net,1433;Initial Catalog=timesheet;Persist Security Info=False;User ID=hyeena;Password=Polta123Polta123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        public DbSet<Timesheet> Timesheets { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}