using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace authdemo.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Matricule { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }

        public int? InstructorID { get; set; }
        public int? StageID { get; set; }

    }
}
