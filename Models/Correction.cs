using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace authdemo.Models
{
    public class Correction
    {
        public int ID { get; set; }

        public int Note { get; set; }

        public string Comments { get; set; }

        public int RapportID { get; set; }
    }
}
