using Ilm.CodeAudition.Service.Models;
using Microsoft.EntityFrameworkCore;

namespace Ilm.CodeAudition.Service
{
    public class Database : DbContext
    {
        public DbSet<Timesheet> Timesheets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Ilm.CodeAudition.Service.db");
        }
    }
}