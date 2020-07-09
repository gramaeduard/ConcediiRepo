using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Concedii.Models
{
    public class Personal
    {   [Key]
        public int PersonalId { get; set; }

        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int NrZileConcediuFolosite { get; set; }
        public ICollection<Concediu> Concedii { get; set; }

        public int DepartamentId { get; set; }

        public Departament Departament { get; set; }





    }
}
