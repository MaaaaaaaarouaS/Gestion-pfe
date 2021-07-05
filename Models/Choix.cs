using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace authdemo.Models
{
    public class Choix
    {
        public string NomCompletEtudiant { get; set; }
        public string Message { get; set; }

        //public int StageId { get; set; }
        [ForeignKey("Student")]
        public Stage student { get; set; }
    }
}
