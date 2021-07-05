using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace authdemo.Models
{
    public class Instructor
    {
        public int ID { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Email { get; set; }


        public ICollection<Student> Students { get; set; }
    }
}
