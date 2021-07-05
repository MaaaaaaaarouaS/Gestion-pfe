using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace authdemo.Models
{
    public class Rapport
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateDepot { get; set; }

        //public int StageId { get; set; }
        [ForeignKey("Stage")]
        public Stage stage { get; set; }
    }
}
