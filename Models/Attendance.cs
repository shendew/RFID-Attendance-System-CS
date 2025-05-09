using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_System.Models
{
    public class Attendance
    {

        public string RFID { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string Day { get; set; }
        public string IN_TIME { get; set; }
        public string OUT_TIME { get; set; }

    }
}
