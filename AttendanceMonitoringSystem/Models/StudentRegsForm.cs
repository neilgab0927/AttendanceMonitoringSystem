using System;
using System.Web;

namespace AttendanceMonitoringSystem.Models
{
    public class StudentRegsForm
    {
        // Student Registration Form

        public int ID { get; set; }

        public string StudentName { get; set; }

        public string Program { get; set; }

        public int Year { get; set; } 

        public string Position { get; set; }
    }
}
