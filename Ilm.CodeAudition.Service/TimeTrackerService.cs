using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Ilm.CodeAudition.Service.Models;


namespace Ilm.CodeAudition.Service
{
    public class TimeTrackerService
    {
        public void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        public void Save(Timesheet timesheet)
        {
            var db = new Database();
            var dbTimesheet = db.Timesheets.Find(timesheet.Id);
            dbTimesheet.Monday = timesheet.Monday;
            dbTimesheet.Tuesday = timesheet.Tuesday;
            dbTimesheet.Wednesday = timesheet.Wednesday;
            dbTimesheet.Thursday = timesheet.Thursday;
            dbTimesheet.Friday = timesheet.Friday;
            dbTimesheet.Total = timesheet.Total;
            db.SaveChanges();
        }

        public IList<Timesheet> GetAll()
        {
            var db = new Database();
            return db.Timesheets.ToList();
        }
    }
}
