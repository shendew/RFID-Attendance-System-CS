using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_System.Models
{
    public class Student
    {
        public int StudentId { get; set; }   
        public string Name { get; set; }
        public string Telephone { get; set; }

        public string Rfid { get; set; }
    }
}
