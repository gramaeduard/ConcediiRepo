using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Concedii.Models
{
    public class Departament
    {
        [Key]
        public int DepartamentId { get; set; }

        public string NumeDepartament { get; set; }

        public ICollection<Personal> Angajati { get; set; }

    }
}
