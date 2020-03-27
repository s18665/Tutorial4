using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial3.Models
{
    public class Student
    {
        public string IndexNumber { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }
        public string Studies { get; set; }
        public int Semester { get; set; }
    }
}
