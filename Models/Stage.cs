using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace authdemo.Models
{
    public class Stage
    {
        public int Id { get; set; }
        public string SujetStage { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string EntrepriseStage { get; set; }
        public ICollection<Rapport> Rapports { get; set; }


    }
}
